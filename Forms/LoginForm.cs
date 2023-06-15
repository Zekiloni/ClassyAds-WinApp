using System;
using System.Windows.Forms;
using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using ClassyAdsWinApp.Services;

namespace ClassyAdsWinApp.Forms
{
    public partial class LoginForm : BaseForm
    {
        private IUserService userService;

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            userService = new UserService();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            UserLoginInput input = new UserLoginInput { Username = username, Password = password };

            var response = userService.Login(input);
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
