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
        public LoggedUser loggedUser { get; set; }

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
                BasicUser basicUser = new BasicUser();
                basicUser.idUser = loggedUser.idUser;
                basicUser.name = loggedUser.name;
                basicUser.surname = loggedUser.surname;
                basicUser.username = loggedUser.username;
                basicUser.description = loggedUser.description;
                basicUser.idUserType = loggedUser.idUserType;

                var historyForm = new DiseasesHistoryForm();
                historyForm.historyUser = basicUser;
                historyForm.Location = this.Location;
                historyForm.StartPosition = FormStartPosition.Manual;
                historyForm.FormClosing += delegate { this.Show(); };
                historyForm.Show();
                this.Hide();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RegisterUser newOne = new RegisterUser();
            newOne.idUser = loggedUser.idUser;
            newOne.username = usernameTextBox.Text;
            newOne.password = passwordTextBox.Text;
            newOne.name = nameTextBox.Text;
            newOne.surname = surnameTextBox.Text;
            newOne.idUserType = loggedUser.idUserType;

            var json = JsonConvert.SerializeObject(newOne);

            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/users/"+loggedUser.idUser;
            rest.httpMethod = httpVerb.PUT;
            rest.content = json;

            string strResponse = string.Empty;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem z zapisaniem zmian.");
                return;
            }
            LoggedUser update = new LoggedUser();
            update.idUser = newOne.idUser;
            update.username = newOne.username;
            update.name = newOne.name;
            update.surname = newOne.surname;
            update.idUserType = newOne.idUserType;
            loggedUser = update;
            MessageBox.Show("Pomyślnie zapisano zmiany.");
        }

        private void editUsersProfileForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = loggedUser.name;
            surnameTextBox.Text = loggedUser.surname;
            usernameTextBox.Text = loggedUser.username;
            passwordTextBox.Text = "";

            //Hide changeHistoryButton for doctor
            if(loggedUser.idUserType == 2)
            {
                changeHistoryButton.Text = "DODAJ ZMIANĘ";
            }
        }
    }
}
