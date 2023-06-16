using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using ClassyAdsWinApp.Services;
using System;
using System.Windows.Forms;

namespace ClassyAdsWinApp.Forms
{
    public partial class RegisterForm : BaseForm
    {
        private IUserService userService;


        public RegisterForm()
        {
            InitializeComponent();
            this.Load += RegisterForm_Load;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            userService = new UserService();
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;
            string firstName = FirstNameTextbox.Text;
            string lastName = LastNameTextbox.Text;
            string email = EmailTextbox.Text;
            DateTime birthday = BirthdayDatePicker.Value;

            if (string.IsNullOrEmpty(username) )
            {
                MessageBox.Show("Username is required field.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required field.");
                return;
            }

            if (string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Password is required field.");
                return;
            }

            if (string.IsNullOrEmpty (firstName) )
            {
                MessageBox.Show("First name is required field.");
                return;
            }

            if (string.IsNullOrEmpty(lastName) )
            {
                MessageBox.Show("Last name is required field.");
                return;
            }

            UserRegisterInput input = new UserRegisterInput
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = email,
                DateOfBirth = birthday,
            };

            var user = await userService.Register(input);

            if (user == null)
            {
                MessageBox.Show("Registration failed.");
            } else
            {
                BackToMainButton_Click(sender, new EventArgs());
            }
        }
    }
}
