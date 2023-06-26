using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using WorldTech.DI;

namespace WorldTech
{
    public partial class CartForm : Form
    {
        private Configuration configuration;
        private IUser user;
        private IShop shop;
        public CartForm(Configuration config, IUser currentUser, IShop currentShop)
        {
            InitializeComponent();
            configuration = config;
            user = currentUser;
            shop = currentShop;
            ShowProductsInCart();
        }
        private void ShowProductsInCart()
        {
            foreach (var product in JsonConvert.DeserializeObject<List<(string, int, int)>>(FindCartsOwner(user).CartJson))
            {
                ListViewItem item = MakeNewItem(product);
                listOfProductsInCart.Items.Add(item);
            }
        }
        private ListViewItem MakeNewItem((string, int, int) product)
        {
            ListViewItem item = new ListViewItem(product.Item1);
            item.SubItems.Add(product.Item2.ToString());
            item.SubItems.Add(product.Item3.ToString());
            return item;
        }
        private IUser FindCartsOwner(IUser currentUser)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser user = shop.FindCurrentUser(currentUser);
            return user;
        }
        private void RemoveProductFromCart(IUser currentUser, (string, int, int) product)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser user = shop.FindCurrentUser(currentUser);
            (string, int, int) productToRemove = shop.FindProductInCart(currentUser, product);
            shop.RemoveProductFromCart(user, productToRemove);
        }
        private (string, int, int) GetTheProductFromListView()
        {
            (string, int, int) product;
            product.Item1 = listOfProductsInCart.SelectedItems[0].SubItems[0].Text;
            product.Item2 = Convert.ToInt32(listOfProductsInCart.SelectedItems[0].SubItems[1].Text);
            product.Item3 = Convert.ToInt32(listOfProductsInCart.SelectedItems[0].SubItems[2].Text);
            return product;
        }
        private void deleteFromCartButton_Click(object sender, EventArgs e)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser currentUser = shop.FindCurrentUser(user);
            (string, int, int) product = GetTheProductFromListView();
            List<(string, int, int)> userCart = JsonConvert.DeserializeObject<List<(string, int, int)>>(currentUser.CartJson);
            (string, int, int) productToRemove = userCart.SingleOrDefault(unknownProduct => unknownProduct.Item1.Equals(shop.FindProductInCart(currentUser, product).Item1));
            productToRemove.Item2 -= 1;
            RemoveProductFromCart(currentUser, productToRemove);
            if (productToRemove.Item2 <= 0)
            {
                listOfProductsInCart.SelectedItems[0].Remove();
            }
            else
            {
                listOfProductsInCart.SelectedItems[0].SubItems[1].Text = productToRemove.Item2.ToString();
            }
        }
        private void clearTheCart_Click(object sender, EventArgs e)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser currentUser = shop.FindCurrentUser(user);
            List<(string, int, int)> userCart = JsonConvert.DeserializeObject<List<(string, int, int)>>(currentUser.CartJson);
            foreach (var product in userCart)
            {
                int productAmount = product.Item2;
                while(productAmount > 0)
                {
                    RemoveProductFromCart(currentUser, product);
                    productAmount--;
                }
            }
            listOfProductsInCart.Items.Clear();
        }
        private void placeAnOrderButton_Click(object sender, EventArgs e)
        {
            ICheck check = configuration.Container.GetInstance<ICheck>();
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser currentUser = shop.FindCurrentUser(user);
            List<(string, int, int)> userCart = JsonConvert.DeserializeObject<List<(string, int, int)>>(currentUser.CartJson);
            check.Shop = shop;
            check.CheckJson = currentUser.CartJson;
            check.CheckData = userCart;
            check.DateTime = DateTime.Now;
            check.UserId = currentUser.Id;
            foreach(var product in userCart)
            {
                check.Price += product.Item3;
            }
            OrderRegistrationForm orderRegistrationForm = new OrderRegistrationForm(check, configuration, currentUser);
            orderRegistrationForm.TopMost = true;
            orderRegistrationForm.Show();
            Close();
        }
    }
}
