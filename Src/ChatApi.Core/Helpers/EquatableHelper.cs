namespace ChatApi.Core.Helpers
{
    /// <summary/>
    public static class EquatableHelper
    {
        /// <summary/>
        public static bool IsEquatable<T>(T? left, T? right) where T : class => 
            right?.Equals(left) ?? left is null;
    }
}