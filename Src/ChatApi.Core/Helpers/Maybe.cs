using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WhatsAppApi.Core.Helpers.Interfaces;
using WhatsAppApi.Core.JsonConversion.Models;

namespace WhatsAppApi.Core.Helpers
{
    public abstract class Maybe<T>
    {
        private protected readonly Exception Exception = null!;
        private protected readonly T Value = default!;

        protected internal Maybe(T value) => Value = value;
        protected internal Maybe(Exception exception) => Exception = exception;

        public static Maybe<T> GetMaybe(
            Func<T> value,
            string exceptionMessage = default!,
            [CallerMemberName] string methodName = default!,
            [CallerFilePath] string sourceFilePath = default!,
            [CallerLineNumber] int sourceLineNumber = default)
        {
            try
            {
                var result = value() ?? throw new NullReferenceException();
                return new Success<T>(result);
            }
            catch (Exception e)
            {
                var traceLogger = new TraceLogger(methodName!, sourceLineNumber!, sourceFilePath!);

                if (!string.IsNullOrWhiteSpace(exceptionMessage))
                    return new Failure<T>(new MonadException(traceLogger, new Exception($"{e.Message} {exceptionMessage}", e)));
                
                return e is MonadException {Message: @"default"} 
                    ? null! 
                    : new Failure<T>(new MonadException(traceLogger, e));
            }
        }
        
        public static Maybe<Task> GetMaybe(
            Action value,
            [CallerMemberName] string methodName = default!,
            [CallerFilePath] string sourceFilePath = default!,
            [CallerLineNumber] int sourceLineNumber = default)
        {
            try
            {
                value();
                return new Success<Task>(new Task(value));
            }
            catch (Exception e)
            {
                if (e is MonadException {Message: @"default"}) return null!;
                var traceLogger = new TraceLogger(methodName!, sourceLineNumber!, sourceFilePath!);
                return new Failure<Task>(new MonadException(traceLogger, e));
            }
        }
    }

    public static class MaybeHelper
    {
        public static TErrorResponse GetResult<TErrorResponse>(this Maybe<Deserializer<TErrorResponse>> maybe) 
            where TErrorResponse : class, IErrorResponse, new() => maybe switch
        {
            Success<Deserializer<TErrorResponse>> success => success.GetValue().Result!,
            Failure<Deserializer<TErrorResponse>> failure => new TErrorResponse { ErrorMessage = $"WhatsAppApi's Error: {failure.GetException()}"},
            _ => throw new NotImplementedException()
        };
    }
    
    public sealed class Success<T> : Maybe<T>
    {
        internal Success(T value) : base(value) { }        
        public T GetValue() => Value;
    }
    public sealed class Failure<T> : Maybe<T>
    {
        internal Failure(Exception exception) : base(exception) { }
        public Exception GetException() => Exception;
    }
    
    public class TraceLogger
    {
        public string MemberName { get; }
        public int SourceLineNumber { get; }
        public string ExceptionPath { get; }
        public TraceLogger(string memberName, int sourceLineNumber, string exceptionPath)
        {
            MemberName = memberName;
            SourceLineNumber = sourceLineNumber;
            ExceptionPath = exceptionPath;
        }
    }
    public class MonadException : Exception
    {
        public string MemberName { get; }
        public int SourceLineNumber { get; }
        public string ExceptionPath { get; }


#pragma warning disable 8618
        public MonadException() : base(@"default") { }
        public MonadException(string message) : base(message) { }
#pragma warning restore 8618
        
        protected internal MonadException(TraceLogger traceLogger, Exception innerException, string message = null!) : 
            base(string.IsNullOrWhiteSpace(message) ? innerException.Message : message, innerException)
        {
            MemberName = traceLogger.MemberName;
            SourceLineNumber = traceLogger.SourceLineNumber;
            ExceptionPath = traceLogger.ExceptionPath;
        }

        public override string ToString() => string.Concat
        (
            $"\"{nameof(Message)}\": {Message} {Environment.NewLine}",
            $"\"{nameof(MemberName)}\": {MemberName} {Environment.NewLine}",
            $"\"{nameof(ExceptionPath)}\": {ExceptionPath} {Environment.NewLine}",
            $"\"{nameof(SourceLineNumber)}\": {SourceLineNumber}"
        );
    }
}