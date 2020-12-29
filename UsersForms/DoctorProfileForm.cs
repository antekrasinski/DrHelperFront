using DrHelperFront.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront
{
    public partial class DoctorProfileForm : Form
    {
        public BasicUser doctorUser { get; set; }
        public LoggedUser loggedUser { get; set; }
        public DoctorProfileForm()
        {
            InitializeComponent();
        }

        private void UserDoctorProfileForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = doctorUser.name;
            surnameLabel.Text = doctorUser.surname;
            descriptionLabel.Text = doctorUser.description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            SchedulerFrom scheduler = new SchedulerFrom();
            scheduler.loggedUser = loggedUser;
            scheduler.chosenDoctor = doctorUser;
            scheduler.Location = this.Location;
            scheduler.StartPosition = FormStartPosition.Manual;
            scheduler.FormClosing += delegate { this.Show(); };
            scheduler.Show();
            this.Hide();
        }
    }
}
