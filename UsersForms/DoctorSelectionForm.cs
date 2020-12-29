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

namespace DrHelperFront
{
    public partial class DoctorSelectionForm : Form
    {
        public LoggedUser loggedUser { get; set; }
        public BasicUser chosenDoctor { get; set; }

        public List<BasicUser> docList = new List<BasicUser>();

        public DoctorSelectionForm()
        {
            InitializeComponent();
        }

        private void doctorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenDoctor = docList[doctorsList.SelectedIndex];
            nameLabel.Text = chosenDoctor.name;
            surnameLabel.Text = chosenDoctor.surname;
            descriptionLabel.Text = chosenDoctor.description;
        }

        private void DoctorSelectionForm_Load(object sender, EventArgs e)
        {
            //Get all users
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
                MessageBox.Show("Problem getting list of doctors.");
                return;
            }
            var usersList = JsonConvert.DeserializeObject<List<BasicUser>>(strResponse);

            //Create list with doctors
            foreach (BasicUser element in usersList)
            {
                //Other then patiens == doctorsId
                if (element.idUserType == 2)
                {
                    docList.Add(element);
                    doctorsList.Items.Add(element.name + " " + element.surname);
                }
            }

            if(usersList != null)
            {
                doctorsList.SelectedIndex = 0;
                chosenDoctor = docList[0];
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersScheduleButton_Click(object sender, EventArgs e)
        {
            SchedulerFrom scheduler = new SchedulerFrom();
            scheduler.loggedUser = loggedUser;
            scheduler.chosenDoctor = null;
            scheduler.Location = this.Location;
            scheduler.StartPosition = FormStartPosition.Manual;
            scheduler.FormClosing += delegate { this.Show(); };
            scheduler.Show();
            this.Hide();
        }

        private void doctorsScheduleButton_Click(object sender, EventArgs e)
        {
            SchedulerFrom scheduler = new SchedulerFrom();
            scheduler.loggedUser = loggedUser;
            scheduler.chosenDoctor = chosenDoctor;
            scheduler.Location = this.Location;
            scheduler.StartPosition = FormStartPosition.Manual;
            scheduler.FormClosing += delegate { this.Show(); };
            scheduler.Show();
            this.Hide();
        }

        private void editProfileButton_Click(object sender, EventArgs e)
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
        
        private void prescriptionsButton_Click(object sender, EventArgs e)
        {
            var prescriptionsForm = new PrescriptionForm();
            prescriptionsForm.loggedUser = loggedUser;
            prescriptionsForm.Location = this.Location;
            prescriptionsForm.StartPosition = FormStartPosition.Manual;
            prescriptionsForm.FormClosing += delegate { this.Show(); };
            prescriptionsForm.Show();
            this.Hide();
        }
    }
}
