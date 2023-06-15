using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using ClassyAdsWinApp.Services;
using System;
using System.Windows.Forms;

namespace ClassyAdsWinApp.Forms
{
    public partial class LoginForm : Form
    {
        private IUserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _userService = new UserService();
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

            var respone = _userService.Login(input);
        }
    }
}
