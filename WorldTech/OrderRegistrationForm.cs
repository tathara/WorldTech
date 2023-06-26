using Newtonsoft.Json;
using WorldTech.DI;

namespace WorldTech
{
    public partial class OrderRegistrationForm : Form
    {
        private IUser user;
        private ICheck check;
        private Configuration configuration;
        public OrderRegistrationForm(ICheck currentCheck, Configuration config, IUser currentUser)
        {
            InitializeComponent();
            user = currentUser;
            check = currentCheck;
            configuration = config;
            finalPrice.Text += check.Price.ToString();
        }

        private void placeAnOrderButton_Click(object sender, EventArgs e)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser currentUser = shop.FindCurrentUser(user);
            shop.CreateCheck(check);
            foreach(var product in JsonConvert.DeserializeObject<List<(string, int, int)>>(currentUser.CartJson))
            {
                int productAmount = product.Item2;
                while(productAmount > 0)
                {
                    shop.RemoveProductFromCart(currentUser, product);
                    productAmount--;
                }
            }
            CheckForm checkForm = new CheckForm(check);
            checkForm.TopMost = true;
            checkForm.Show();
            Close();
        }
        private void ChangeSelectionColor(ComboBox comboBox, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Linen);

            e.DrawBackground();
            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void paymentMethodBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ChangeSelectionColor(paymentMethodBox, e);
        }

        private void receiveMethodBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ChangeSelectionColor(receiveMethodBox, e);
        }
    }
}
