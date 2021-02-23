using System;

namespace ChatApi.Core.Response.Interfaces
{
    public interface IChatApiResponse<out T>
    {
        bool IsSuccess { get; }
        Exception? Exception { get; }
        
        T? GetResult();
    }
}