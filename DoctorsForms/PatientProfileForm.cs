using DrHelperFront.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront.DoctorsForms
{
    public partial class PatientProfileForm : Form
    {
        public User patientUser { get; set; }
        public User loggedUser { get; set; }
        public PatientProfileForm()
        {
            InitializeComponent();
        }

        private void PatientProfileForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = patientUser.name;
            surnameLabel.Text = patientUser.surname;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            var historyForm = new DiseasesHistoryForm();
            historyForm.historyUser = patientUser;
            historyForm.Location = this.Location;
            historyForm.StartPosition = FormStartPosition.Manual;
            historyForm.FormClosing += delegate { this.Show(); };
            historyForm.Show();
            this.Hide();
        }
    }
}
