namespace ChatApi.Core.Helpers
{
    public static class EquatableHelper
    {
        public static bool IsEquatable<T>(T? left, T? right) where T : class => 
            right?.Equals(left) ?? left is null;
    }
}