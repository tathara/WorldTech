namespace WorldTech.DI
{
    public interface IProduct
    {
        string Type { get; set; }
        string Model { get; set; }
        string Manufacturer { get; set; }
        int Price { get; set; }
        double Rating { get; set; }
        int Amount { get; set; }
    }
}
