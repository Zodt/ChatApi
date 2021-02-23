namespace ChatApi.Core.Models.Interfaces
{
    public interface IPrintable
    {
        string PrintMembers();
        string PrintMembers(int shift);
    }
}