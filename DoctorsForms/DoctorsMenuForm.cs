using DrHelperFront.Models;
using DrHelperFront.UsersForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront.DoctorsForms
{
    public partial class DoctorsMenuForm : Form
    {
        public LoggedUser loggedUser { get; set; }
        public DoctorsMenuForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditUsersProfileForm();
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

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            var schedulerForm = new SchedulerFrom();
            schedulerForm.loggedUser = loggedUser;
            schedulerForm.Location = this.Location;
            schedulerForm.StartPosition = FormStartPosition.Manual;
            schedulerForm.FormClosing += delegate { this.Show(); };
            schedulerForm.Show();
            this.Hide();
        }

        private void perscriptionsButton_Click(object sender, EventArgs e)
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
