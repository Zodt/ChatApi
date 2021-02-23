namespace ChatApi.Core.Models.Interfaces
{
    internal interface IPrintableCollection : IPrintable
    {
        string PrintMembers(int countElementPrint, int shift = default);
    }

    interface IPrintableSetting
    {
        
    }

    interface IPrintableCollectionSettings : IPrintableSetting
    {
        
    }
    
}