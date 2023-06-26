namespace WorldTech.DI
{
    public interface IUserData<T>
    {
        void AddUser(T user);
        IUser FindUser(T user);
        void AddProductToUsersCart(IUser user, IProduct product);
        int GiveIdToUser();
        bool IsThereAnEqualLogin(string login);
        void RemoveProductFromCart(IUser user, (string, int, int) product);
        (string, int, int) FindProductInCart(IUser user, (string, int, int) product);
    }
}
