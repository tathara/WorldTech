namespace WorldTech.DI
{
    public interface ICheck
    {
        ICart Cart { get; set; }
        IShop Shop { get; set; }
        List<(string, int, int)> CheckData { get; set; }
        string CheckJson { get; set; }
        int Price { get; set; }
        int UserId { get; set; }
        DateTime DateTime { get; set; }
    }
}
