using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Bll
{
    public class Shop : IShop
    {
        private readonly IProductsData<IProduct> productData;
        private readonly ICheckData<ICheck> checkData;
        private readonly IUserData<IUser> userData;

        public string Name { get; set; }
        public string Address { get; set; }

        public Shop(IProductsData<IProduct> _productData, ICheckData<ICheck> _checkData, IUserData<IUser> _userData)
        {
            productData = _productData ??
                throw new ArgumentNullException(nameof(_productData));
            checkData = _checkData ??
                throw new ArgumentNullException(nameof(_checkData));
            userData = _userData ??
                throw new ArgumentNullException(nameof(_userData));
        }

        public void AddToCart(IUser user, IProduct product)
        {
            userData.AddProductToUsersCart(user, product);
        }

        public IUser FindCurrentUser(IUser user)
        {
            return userData.FindUser(user);
        }

        public void AddUser(IUser user)
        {
            userData.AddUser(user);
        }

        public bool IsThereAnEqualLogin(string login)
        {
            return userData.IsThereAnEqualLogin(login);
        }

        public int ReturnIdToUser()
        {
            return userData.GiveIdToUser();
        }

        public (string, int, int) FindProductInCart(IUser user, (string, int, int) product)
        {
            return userData.FindProductInCart(user, product);
        }

        public void RemoveProductFromCart(IUser user, (string, int, int) product)
        {
            userData.RemoveProductFromCart(user, product);
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            return productData.UpdateProductList();
        }

        public void CreateCheck(ICheck check)
        {
            checkData.AddCheck(check);
        }
    }
}
