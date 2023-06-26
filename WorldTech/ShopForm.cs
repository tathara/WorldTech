using WorldTech.DI;

namespace WorldTech
{
    public delegate void UserChanger(IUser user);

    public partial class ShopForm : Form
    {
        public IUser user;
        public IShop shop;
        private Configuration configuration;

        public ShopForm()
        {
            InitializeComponent();
            configuration = new Configuration();
            shop = CreateShop("WorldTech", "��. ��������-���������������� ����������������, �. 3");
            ShowAllProducts();
            user = CreateUnknownUser();
        }

        #region ��������� ������������(DI)
        private IEnumerable<IProduct> GetAllProducts()
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            var products = shop.GetAllProducts();
            return products;
        }

        private void ShowAllProducts()
        {
            var products = GetAllProducts();
            foreach (var product in products)
            {
                ListViewItem item = MakeNewItem(product);
                listOfProducts.Items.Add(item);
            }
        }

        private ListViewItem MakeNewItem(IProduct product)
        {
            ListViewItem item = new ListViewItem(product.Type);
            item.SubItems.Add(product.Manufacturer);
            item.SubItems.Add(product.Model);
            item.SubItems.Add(product.Price.ToString());
            item.SubItems.Add(product.Rating.ToString());
            return item;
        }

        private IShop CreateShop(string name, string address)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            shop.Name = name;
            shop.Address = address;
            return shop;
        }

        private IUser CreateUnknownUser()
        {
            ICart cart = configuration.Container.GetInstance<ICart>();
            IUser unknownUser = configuration.Container.GetInstance<IUser>();
            IShop shop = configuration.Container.GetInstance<IShop>();
            unknownUser.Name = "������������";
            unknownUser.Login = "";
            unknownUser.Password = "";
            unknownUser.Cart = cart;
            shop.AddUser(unknownUser);
            unknownUser = shop.FindCurrentUser(unknownUser);
            return unknownUser;
        }

        public void ChangeCurrentUser(IUser newUser)
        {
            user = newUser;
            userNameText.Text = user.Name;
            userButton.Enabled = false;
            userButton.Visible = false;
            signOutButton.Enabled = true;
            signOutButton.Visible = true;
        }
        #endregion
        #region ����� ��������� � ����� �� ����
        private void cpusLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("���������  ");
        }

        private void motherboardsLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("����������� �����");
        }

        private void gpusLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("����������");
        }

        private void casesLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("������");
        }

        private void ramLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("����������� ������");
        }

        private void powerSuppliesLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("���� �������");
        }

        private void coolingSystemsLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("����������");
            ShowCertainProducts("�����");
        }

        private void hddsLabel_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts("����������");
            ShowCertainProducts("������� ����");
        }

        private void inputText_Enter(object sender, EventArgs e)
        {
            inputText.Text = ChangeFindFieldText(inputText.Text);
        }

        private void inputText_Leave(object sender, EventArgs e)
        {
            inputText.Text = ChangeFindFieldText(inputText.Text);
        }
        #endregion
        #region ���������� ������
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            IProduct product = configuration.Container.GetInstance<IProduct>();
            IShop shop = configuration.Container.GetInstance<IShop>();
            string productType = listOfProducts.SelectedItems[0].SubItems[0].Text;
            string productManufacturer = listOfProducts.SelectedItems[0].SubItems[1].Text;
            string productModel = listOfProducts.SelectedItems[0].SubItems[2].Text;
            int productPrice = Convert.ToInt32(listOfProducts.SelectedItems[0].SubItems[3].Text);
            double productRating = Convert.ToDouble(listOfProducts.SelectedItems[0].SubItems[4].Text);
            product.Type = productType;
            product.Manufacturer = productManufacturer;
            product.Model = productModel;
            product.Price = productPrice;
            product.Rating = productRating;
            shop.AddToCart(user, product);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(configuration, this);
            signUpForm.TopMost = true;
            signUpForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowAllProducts();
        }
        private void cartButton_Click(object sender, EventArgs e)
        {
            IShop currentShop = configuration.Container.GetInstance<IShop>();
            IUser currentUser = currentShop.FindCurrentUser(user);
            if (currentUser.CartJson == null)
            {
                MessageBox.Show("�������� ������� � ������� ����� �� ���������!", "���� ������� �����!");
            }
            else
            {
                CartForm cartForm = new CartForm(configuration, user, shop);
                cartForm.TopMost = true;
                cartForm.Show();
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            user = CreateUnknownUser();
            signOutButton.Enabled = false;
            signOutButton.Visible = false;
            userButton.Enabled = true;
            userButton.Visible = true;
            userNameText.Text = "�����";
        }
        #endregion
        #region ����� ��������� � �����
        private void findButton_Click(object sender, EventArgs e)
        {
            listOfProducts.Items.Clear();
            ShowCertainProducts(inputText.Text);
        }
        private string ChangeFindFieldText(string input)
        {
            if (input == "����� ��������")
            {
                input = "";
                return input;
            }
            if (input == "")
            {
                input = "����� ��������";
                return input;
            }
            return input;
        }
        private void ShowCertainProducts(string input)
        {
            var products = GetAllProducts();
            foreach (var product in products)
            {
                if (input != "���������  ")
                {
                    if (product.Type.ToLower().Contains(input.ToLower()) || product.Manufacturer.ToLower().Contains(input.ToLower())
                        || product.Model.ToLower().Contains(input.ToLower()))
                    {
                        ListViewItem item = MakeNewItem(product);
                        listOfProducts.Items.Add(item);
                    }
                }
                else
                {
                    if (product.Type == "���������")
                    {
                        ListViewItem item = MakeNewItem(product);
                        listOfProducts.Items.Add(item);
                    }
                }

            }
        }
        #endregion
        #region ����������� ������ ��� ���������
        private void cpusLabel_MouseEnter(object sender, EventArgs e)
        {
            cpusLabel.ForeColor = Color.Tomato;
        }

        private void cpusLabel_MouseLeave(object sender, EventArgs e)
        {
            cpusLabel.ForeColor = Color.Black;
        }

        private void motherboardsLabel_MouseEnter(object sender, EventArgs e)
        {
            motherboardsLabel.ForeColor = Color.Tomato;
        }

        private void motherboardsLabel_MouseLeave(object sender, EventArgs e)
        {
            motherboardsLabel.ForeColor = Color.Black;
        }

        private void gpusLabel_MouseEnter(object sender, EventArgs e)
        {
            gpusLabel.ForeColor = Color.Tomato;
        }

        private void gpusLabel_MouseLeave(object sender, EventArgs e)
        {
            gpusLabel.ForeColor = Color.Black;
        }

        private void casesLabel_MouseEnter(object sender, EventArgs e)
        {
            casesLabel.ForeColor = Color.Tomato;
        }

        private void casesLabel_MouseLeave(object sender, EventArgs e)
        {
            casesLabel.ForeColor = Color.Black;
        }

        private void ramLabel_MouseEnter(object sender, EventArgs e)
        {
            ramLabel.ForeColor = Color.Tomato;
        }

        private void ramLabel_MouseLeave(object sender, EventArgs e)
        {
            ramLabel.ForeColor = Color.Black;
        }

        private void powerSuppliesLabel_MouseEnter(object sender, EventArgs e)
        {
            powerSuppliesLabel.ForeColor = Color.Tomato;
        }

        private void powerSuppliesLabel_MouseLeave(object sender, EventArgs e)
        {
            powerSuppliesLabel.ForeColor = Color.Black;
        }

        private void coolingSystemsLabel_MouseEnter(object sender, EventArgs e)
        {
            coolingSystemsLabel.ForeColor = Color.Tomato;
        }
        private void coolingSystemsLabel_MouseLeave(object sender, EventArgs e)
        {
            coolingSystemsLabel.ForeColor = Color.Black;
        }

        private void hddsLabel_MouseEnter(object sender, EventArgs e)
        {
            hddsLabel.ForeColor = Color.Tomato;
        }

        private void hddsLabel_MouseLeave(object sender, EventArgs e)
        {
            hddsLabel.ForeColor = Color.Black;
        }
        #endregion
    }
}