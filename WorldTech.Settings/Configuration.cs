using SimpleInjector;
using WorldTech.Bll;
using WorldTech.Data.Sql;
using WorldTech.DI;

public class Configuration
{
    public Container Container { get; }

    public Configuration()
    {
        Container = new Container();

        Setup();
    }

    public virtual void Setup()
    {
        Container.Register<IProduct, Product>(Lifestyle.Transient);
        Container.Register<ICheck, Check>(Lifestyle.Transient);
        Container.Register<IUser, User>(Lifestyle.Transient);
        Container.Register<ICart, Cart>(Lifestyle.Transient);
        Container.Register<IShop, Shop>(Lifestyle.Singleton);
        Container.Register<IUserData<IUser>, UserDataSql>
            (Lifestyle.Singleton);
        Container.Register<ICheckData<ICheck>, CheckDataSql>
            (Lifestyle.Singleton);
        Container.Register<IProductsData<IProduct>, ProductDataSql>
            (Lifestyle.Singleton);
    }
}