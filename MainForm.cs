using System;
using System.Windows.Forms;
using ClassyAdsWinApp.Forms;
using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using ClassyAdsWinApp.Services;

namespace ClassyAdsWinApp
{
    public partial class MainForm : BaseForm
    {
        private IUserService userService;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userService = new UserService();

            if (UserSession.Active.IsLoggedIn())
            {
                GoToRegisterButton.Visible = false;
                GoToLoginButton.Visible = false;

                SelectLoginOrRegisterLabel.Visible = false;
                GoToCategoriesGrid.Visible = true;
                LogoutButton.Visible = true;

                UsernameDetailLabel.Text = UserSession.Active.User.Username;
            } else
            {
                UsernameDetailLabel.Visible = false;
                LogoutButton.Visible = false;
                GoToCategoriesGrid.Visible = false;
            }
        }

        private void GoToRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void GoToLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void GoToCategoriesGrid_Click(object sender, EventArgs e)
        {
            CategoryGridViewForm categoryGridViewForm = new CategoryGridViewForm();
            this.Hide();
            categoryGridViewForm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            userService.Logout();
            this.Refresh();
        }
    }
}
