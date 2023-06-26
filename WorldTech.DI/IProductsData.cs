namespace WorldTech.DI
{
    public interface IProductsData<T>
    {
        IEnumerable<T> UpdateProductList();
        IEnumerable<T> FindProducts(string input);
    }
}
