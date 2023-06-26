using System.Collections.Generic;

namespace WorldTech.DI
{
    public interface IShop
    {
        string Name { get; set; }
        string Address { get; set; }
        IEnumerable<IProduct> GetAllProducts();
        void AddToCart(IUser user, IProduct product);
        IUser FindCurrentUser(IUser user);
        void AddUser(IUser user);
        int ReturnIdToUser();
        bool IsThereAnEqualLogin(string login);
        void RemoveProductFromCart(IUser user, (string, int, int) product);
        (string, int, int) FindProductInCart(IUser user, (string, int, int) product);
        void CreateCheck(ICheck check);
    }
}
