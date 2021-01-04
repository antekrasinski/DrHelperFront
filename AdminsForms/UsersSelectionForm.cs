using DrHelperFront.Models;
using DrHelperFront.UsersForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront.AdminsForms
{
    public partial class UsersSelectionForm : Form
    {
        public List<BasicUser> usersList = new List<BasicUser>();
        public LoggedUser loggedUser { get; set; }
        public BasicUser chosenUser { get; set; }

        public UsersSelectionForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProfileButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Location = this.Location;
            registerForm.isAdmin = true;
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.FormClosing += delegate
            {
                this.UsersSelectionForm_Load(sender, e);
                this.Show();
            };
            registerForm.Show();
            this.Hide();
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            //Delete selected user
            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/users/" + chosenUser.idUser;
            rest.httpMethod = httpVerb.DELETE;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem z usuwaniem użytkownika.");
                return;
            }
            this.UsersSelectionForm_Load(sender, e);
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            var loadDataForm = new LoadDataForm();
            loadDataForm.Location = this.Location;
            loadDataForm.loggedUser = loggedUser;
            loadDataForm.StartPosition = FormStartPosition.Manual;
            loadDataForm.FormClosing += delegate
            {
                this.Show();
            };
            loadDataForm.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditUsersProfileForm editForm = new EditUsersProfileForm();
            editForm.loggedUser = loggedUser;
            editForm.Location = this.Location;
            editForm.StartPosition = FormStartPosition.Manual;
            editForm.FormClosing += delegate
            {
                this.loggedUser = editForm.loggedUser;
                this.Show();
            };
            editForm.Show();
            this.Hide();
        }

        private void UsersSelectionForm_Load(object sender, EventArgs e)
        {
            usersList.Clear();
            usersListBox.Items.Clear();

            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/users";
            rest.httpMethod = httpVerb.GET;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem z wczytywaniem lekarzy.");
                return;
            }
            var allUsers = JsonConvert.DeserializeObject<List<BasicUser>>(strResponse);

            foreach (BasicUser element in allUsers)
            {
                //All patients and doctors
                if (element.idUserType != 1)
                {
                    usersList.Add(element);
                    usersListBox.Items.Add(element.name + " " + element.surname);
                }
            }

            if (usersList != null)
            {
                usersListBox.SelectedIndex = 0;
                chosenUser = usersList[0];
            }

        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenUser = usersList[usersListBox.SelectedIndex];

            nameLabel.Text = chosenUser.name;
            surnameLabel.Text = chosenUser.surname;
            if (chosenUser.idUserType == 2)
            {
                descriptionLabel.Text = "LEKARZ " + chosenUser.description;
            }
            else
            {
                descriptionLabel.Text = "PACJENT";
            }
        }
    }
}
