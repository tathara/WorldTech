using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldTech.DI;

namespace WorldTech
{
    public partial class LogInForm : Form
    {
        private ShopForm shopForm;
        private Configuration configuration;
        private UserChanger userChanger;

        public LogInForm(Configuration config, ShopForm shop)
        {
            InitializeComponent();
            configuration = config;
            shopForm = shop;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (loginText.Text == "")
            {
                MessageBox.Show("Введите логин!", "Ошибка ввода");
            }
            else if (passwordText.Text == "")
            {
                MessageBox.Show("Введите пароль!", "Ошибка ввода");
            }
            IUser user = FindUserInDatabase();
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка ввода");
            }
            else
            {
                userChanger += shopForm.ChangeCurrentUser;
                userChanger?.Invoke(user);
                Close();
            }
        }
        private IUser InitializeUser()
        {
            IUser user = configuration.Container.GetInstance<IUser>();
            user.Login = loginText.Text;
            user.Password = passwordText.Text;
            return user;
        }
        private IUser FindUserInDatabase()
        {
            IShop shop = configuration.Container.GetInstance<IShop>();
            IUser foundUser = InitializeUser();
            foundUser = shop.FindCurrentUser(foundUser);
            return foundUser;
        }
        private void returnToRegistration_MouseEnter(object sender, EventArgs e)
        {
            returnToRegistration.Font = new Font("Segoe UI", 12, FontStyle.Italic);
        }
        private void returnToRegistration_MouseLeave(object sender, EventArgs e)
        {
            returnToRegistration.Font = new Font("Segoe UI", 12, FontStyle.Regular);
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
        private void returnToRegistration_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(configuration, shopForm);
            signUpForm.TopMost = true;
            signUpForm.Show();
            Close();
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
    }
}
