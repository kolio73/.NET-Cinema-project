using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cinema.Data;
using System.Windows.Forms;

namespace Cinema.Presentation
{
    public partial class ChangeUsersForm : Form
    {
        private User currentUser;
        public ChangeUsersForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                User oldUser = entities.Users.Find(currentUser.Id);

                User newUser = new User()
                {
                    Id = currentUser.Id,
                    FirstName = firstNameDataLabel.Text,
                    LastName = lastNameDataLabel.Text,
                    UserName = usernameDataLabel.Text,
                    Pass = currentUser.Pass,
                    Role = (int)rolesComboBox.SelectedValue
                };

                entities.Entry(oldUser).CurrentValues.SetValues(newUser);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void ChangeUsersForm_Load(object sender, EventArgs e)
        {
            List<Role> roles;

            using (Entities entities = new Entities())
            {
                roles = entities.Roles.OrderBy(role => role.Id).ToList();
                currentUser = entities.Users.First();
            }

            rolesComboBox.ValueMember = "Id";
            rolesComboBox.DisplayMember = "Name";
            rolesComboBox.DataSource = roles;

            PopulateControls();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                User user = entities.Users.Find(currentUser.Id);
                entities.Users.Remove(user);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (Entities entities = new Entities())
            {
                List<User> prevUsers = entities.Users
                    .Where(user => user.Id < currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (prevUsers.Count > 0)
                {
                    currentUser = prevUsers.Last();
                    PopulateControls();
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (Entities entities = new Entities())
            {
                List<User> nextUsers = entities.Users
                    .Where(user => user.Id > currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (nextUsers.Count > 0)
                {
                    currentUser = nextUsers.First();
                    PopulateControls();
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }
        private void PopulateControls()
        {
            firstNameDataLabel.Text = currentUser.FirstName;
            lastNameDataLabel.Text = currentUser.LastName;
            usernameDataLabel.Text = currentUser.UserName;
            rolesComboBox.SelectedValue = currentUser.Role;
        }
    }
}