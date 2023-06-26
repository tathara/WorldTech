using WorldTech.DI;

namespace WorldTech
{
    public partial class SignUpForm : Form
    {
        private ShopForm shopForm;
        private Configuration configuration;
        private UserChanger userChanger;
        private LogInForm logInForm;
        public SignUpForm(Configuration config, ShopForm shop)
        {
            InitializeComponent();
            configuration = config;
            shopForm = shop;
            logInForm = new LogInForm(config, shop);
        }

        private IUser MakeNewUser()
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser newUser = configuration.Container.GetInstance<IUser>();
            newUser.Name = nameText.Text;
            newUser.Login = loginText.Text;
            if (passwordCheckText.Text == passwordText.Text)
            {
                newUser.Password = passwordText.Text;
            }
            newUser.Id = shop.ReturnIdToUser();
            return newUser;
        }

        private void AddUserToDatabase(IUser user)
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            shop.AddUser(user);
        }

        private void GoToLogInButton_Click(object sender, EventArgs e)
        {
            logInForm.TopMost = true;
            logInForm.Show();
            Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                MessageBox.Show("Введите пароль!", "Ошибка ввода");
            }
            else if (loginText.Text == "")
            {
                MessageBox.Show("Введите логин!", "Ошибка ввода");
            }
            else if (nameText.Text == "")
            {
                MessageBox.Show("Введите имя!", "Ошибка ввода");
            }
            else if(nameText.Text == "Пользователь")
            {
                MessageBox.Show("Данное имя зарезервировано! Введите другое имя!", "Ошибка ввода");
            }
            else if (passwordCheckText.Text == "")
            {
                MessageBox.Show("Повторите введенный пароль!", "Ошибка ввода");
            }
            else if (passwordCheckText.Text != passwordText.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка ввода");
            }
            else
            {
                IShop shop = configuration.Container.GetInstance<IShop>();
                IUser newUser = MakeNewUser();
                if(shop.IsThereAnEqualLogin(newUser.Login) == false)
                {
                    userChanger += AddUserToDatabase;
                    userChanger += shopForm.ChangeCurrentUser;
                    userChanger?.Invoke(newUser);
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка ввода!");
                }
            }
        }

        private void GoToLogInButton_MouseEnter(object sender, EventArgs e)
        {
            GoToLogInButton.Font = new Font("Segoe UI", 12, FontStyle.Italic);
        }

        private void GoToLogInButton_MouseLeave(object sender, EventArgs e)
        {
            GoToLogInButton.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

        private void nameText_Enter(object sender, EventArgs e)
        {
            nameText.Text = ChangeNameText(nameText.Text);
        }

        private void nameText_Leave(object sender, EventArgs e)
        {
            nameText.Text = ChangeNameText(nameText.Text);
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            loginText.Text = ChangeLoginText(loginText.Text);
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            loginText.Text = ChangeLoginText(loginText.Text);
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {
            passwordText.Text = ChangePasswordText(passwordText.Text);
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            passwordText.Text = ChangePasswordText(passwordText.Text);
        }

        private void passwordCheckText_Enter(object sender, EventArgs e)
        {
            passwordCheckText.Text = ChangePasswordCheckText(passwordCheckText.Text);
        }

        private void passwordCheckText_Leave(object sender, EventArgs e)
        {
            passwordCheckText.Text = ChangePasswordCheckText(passwordCheckText.Text);
        }

        private string ChangeNameText(string input)
        {
            if (input == "Имя")
            {
                input = "";
                return input;
            }
            if (input == "")
            {
                input = "Имя";
                return input;
            }
            return input;
        }

        private string ChangeLoginText(string input)
        {
            if (input == "Логин")
            {
                input = "";
                return input;
            }
            if (input == "")
            {
                input = "Логин";
                return input;
            }
            return input;
        }

        private string ChangePasswordText(string input)
        {
            if (input == "Пароль")
            {
                input = "";
                passwordText.UseSystemPasswordChar = true;
                return input;
            }
            if (input == "")
            {
                passwordText.UseSystemPasswordChar = false;
                input = "Пароль";
                return input;
            }
            return input;
        }
        private string ChangePasswordCheckText(string input)
        {
            if (input == "Повторите пароль")
            {
                input = "";
                passwordCheckText.UseSystemPasswordChar = true;
                return input;
            }
            if (input == "")
            {
                passwordCheckText.UseSystemPasswordChar = false;
                input = "Повторите пароль";
                return input;
            }
            return input;
        }
    }
}
