namespace WorldTech.DI
{
    public interface ICart
    {
        List<(IProduct, int)> Products { get; set; }
        int Price { get; set; }
        void BuyProducts(ICart cart);
        void RemoveProductFromCart((IProduct, int) product);
        void RemoveAllProductsFromCart();
    }
}