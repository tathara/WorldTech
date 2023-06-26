using WorldTech.DI;
using Newtonsoft.Json;

namespace WorldTech.Data.Sql
{
    public class UserDataSql : IUserData<IUser>
    {
        public void AddProductToUsersCart(IUser user, IProduct product)
        {
            using (var database = new WorldTechContext())
            {
                (string, int, int) foundProduct = TryToFindAnEqualProductInCart(user, product);
                string productData = $"{product.Type} {product.Manufacturer} {product.Model}";
                                                 List<(string, int, int)> productsList = JsonConvert.DeserializeObject<List<(string, int, int)>>(FindUser(user).CartJson) ?? new List<(string, int, int)>();
                if (foundProduct == ("", 0, 0))
                {
                    productsList.Add((productData, 1, product.Price));
                    database.Users.FirstOrDefault(unknownUser => unknownUser.Equals(FindUser(user))).CartJson = JsonConvert.SerializeObject(productsList);
                }
                else
                {
                    (string, int, int) equalProduct = productsList.SingleOrDefault(unknownProduct => unknownProduct.Item1 == productData);
                    equalProduct.Item2 += 1;
                    productsList.Remove(productsList.SingleOrDefault(unknownProduct => unknownProduct.Item1 == productData));
                    productsList.Add(equalProduct);
                    database.Users.FirstOrDefault(unknownUser => unknownUser.Equals(FindUser(user))).CartJson = JsonConvert.SerializeObject(productsList);
                }
                database.SaveChanges();
            }
        }

        public void AddUser(IUser user)
        {
            using (var database = new WorldTechContext())
            {
                var currentUser = new UserEntity(user);
                currentUser.Id = database.Users.Count() + 1;
                currentUser.Password = HashThePassword(currentUser.Password);
                database.Users.Add(currentUser);
                database.SaveChanges();
            }
        }

        public IUser FindUser(IUser user)
        {
            using (var database = new WorldTechContext())
            {
                if (user.Name == null)
                {
                    IUser currentUser = database.Users.ToList().SingleOrDefault(unknownUser => unknownUser.Login.Equals(user.Login)
                    && unknownUser.Password.Equals(HashThePassword(user.Password)));
                    return currentUser;
                }
                else if (user.Name != "Пользователь")
                {
                    IUser currentUser = database.Users.ToList().SingleOrDefault(unknownUser => unknownUser.Id.Equals(user.Id)
                && unknownUser.Login.Equals(user.Login) && unknownUser.Name.Equals(user.Name)
                && (unknownUser.Password.Equals(user.Password) || unknownUser.Password.Equals(HashThePassword(user.Password))));
                    return currentUser;
                }
                else
                {
                    IUser currentUser = database.Users.OrderBy(user => user.Id).Last();
                    return currentUser;
                }
            }
        }

        public bool IsThereAnEqualLogin(string login)
        {
            using(var database = new WorldTechContext())
            {
                IUser currentUser = database.Users.FirstOrDefault(unknownUser => unknownUser.Login.Equals(login));
                return currentUser != null ? true : false;
            }
        }

        private (string, int, int) TryToFindAnEqualProductInCart(IUser user, IProduct product)
        {
            using (var database = new WorldTechContext())
            {
                List<(string, int, int)> userCart;
                if (FindUser(user).CartJson == "null" || FindUser(user).CartJson == null)
                {
                    return ("", 0, 0);
                }
                else
                {
                    userCart = JsonConvert.DeserializeObject<List<(string, int, int)>>(FindUser(user).CartJson);
                }
                string productData = $"{product.Type} {product.Manufacturer} {product.Model}";
                foreach (var currentProduct in userCart)
                {
                    if (currentProduct.Item1 == productData)
                    {
                        var value = currentProduct;
                        return value;
                    }
                }
                return ("", 0, 0);
            }
        }

        public int GiveIdToUser()
        {
            using (var database = new WorldTechContext())
            {
                int id = database.Users.Count() + 1;
                return id;
            }
        }

        public (string, int, int) FindProductInCart(IUser currentUser, (string, int, int) product)
        {
            using (var database = new WorldTechContext())
            {
                List<(string, int, int)> cart = JsonConvert.DeserializeObject<List<(string, int, int)>>(FindUser(currentUser).CartJson);
                (string, int, int) foundProduct = cart.SingleOrDefault(unknownProduct => unknownProduct.Item1.Equals(product.Item1));
                return foundProduct;
            }
        }

        public void RemoveProductFromCart(IUser currentUser, (string, int, int) product)
        {
            using(var database = new WorldTechContext())
            {
                List<(string, int, int)> productsList = JsonConvert.DeserializeObject<List<(string, int, int)>>(FindUser(currentUser).CartJson);
                (string, int, int) productToRemove = productsList.SingleOrDefault(unknownProduct => unknownProduct.Item1.Equals(FindProductInCart(currentUser, product).Item1));
                productToRemove.Item2 -= 1;
                productsList.Remove(productsList.SingleOrDefault(unknownProduct => unknownProduct.Item1.Equals(FindProductInCart(currentUser, product).Item1)));
                if (productToRemove.Item2 > 0)
                {
                    productsList.Add(productToRemove);
                }
                database.Users.SingleOrDefault(unknownUser => unknownUser.Equals(FindUser(currentUser))).CartJson = JsonConvert.SerializeObject(productsList);
                database.SaveChanges();
            }
        }

        private string HashThePassword(string password)
        {
            PasswordHasher passwordHeasher = new PasswordHasher();
            return passwordHeasher.HashPassword(password);
            
        }
    }
}
