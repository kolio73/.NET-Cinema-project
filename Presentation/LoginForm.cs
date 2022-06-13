using System;
using System.Linq;
using System.Windows.Forms;
using Cinema.Data;
using Cinema.Common;


namespace Cinema.Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 3)
            {
                validUsernameLabel.Text = "Потребителското име трябва да съдържа поне три символа.";
                loginButton.Enabled = false;
            }
            else
            {
                validUsernameLabel.Text = string.Empty;

                if (passwordTextBox.Text.Length > 1)
                {
                    loginButton.Enabled = true;
                }
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length < 2)
            {
                validPasswordLabel.Text = "Паролата трябва да има поне два символа.";
                loginButton.Enabled = false;
            }
            else
            {
                validPasswordLabel.Text = string.Empty;

                if (usernameTextBox.Text.Length > 2)
                {
                    loginButton.Enabled = true;
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User foundUser;

            using (Entities entities = new Entities())
            {
                foundUser = entities.Users.FirstOrDefault(user => user.UserName == username);
            }

            if (foundUser != null)
            {
                if (foundUser.Pass == password)
                {
                    Registrator.LoggedUser = foundUser;

                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show("Грешна парола.", "Некоректен вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Няма такъв потребител.", "Некоректен вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
