using DrHelperFront.DoctorsForms;
using DrHelperFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront.UsersForms
{
    public partial class EditUsersProfileForm : Form
    {
        public User loggedUser { get; set; }

        public EditUsersProfileForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeHistoryButton_Click(object sender, EventArgs e)
        {
            if (loggedUser.idUserType == 2)
            {
                var shiftForm = new shiftForm();
                shiftForm.loggedUser = loggedUser;
                shiftForm.Location = this.Location;
                shiftForm.StartPosition = FormStartPosition.Manual;
                shiftForm.FormClosing += delegate { this.Show(); };
                shiftForm.Show();
                this.Hide();
            }
            else
            {
                var historyForm = new DiseasesHistoryForm();
                historyForm.historyUser = loggedUser;
                historyForm.Location = this.Location;
                historyForm.StartPosition = FormStartPosition.Manual;
                historyForm.FormClosing += delegate { this.Show(); };
                historyForm.Show();
                this.Hide();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User newOne = new User();
            newOne.idUser = loggedUser.idUser;
            newOne.username = usernameTextBox.Text;
            newOne.password = passwordTextBox.Text;
            newOne.name = nameTextBox.Text;
            newOne.surname = surnameTextBox.Text;
            newOne.idUserType = loggedUser.idUserType;

            var json = JsonConvert.SerializeObject(newOne);

            Rest rest = new Rest();
            rest.endPoint = "http://localhost:5000/api/users/"+loggedUser.idUser;
            rest.httpMethod = httpVerb.PUT;
            rest.content = json;

            string strResponse = string.Empty;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem saving changes.");
                return;
            }
            loggedUser = newOne;
        }

        private void editUsersProfileForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = loggedUser.name;
            surnameTextBox.Text = loggedUser.surname;
            usernameTextBox.Text = loggedUser.username;
            passwordTextBox.Text = loggedUser.password;

            //Hide changeHistoryButton for doctor
            if(loggedUser.idUserType == 2)
            {
                changeHistoryButton.Text = "EDIT SHIFT HOURS";
            }
        }
    }
}
