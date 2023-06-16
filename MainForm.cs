using System;
using System.Windows.Forms;
using ClassyAdsWinApp.Forms;

namespace ClassyAdsWinApp
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
    }
}
