using DrHelperFront.Models;
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
    public partial class PrescriptionForm : Form
    {
        public List<Prescription> prescriptionList = new List<Prescription>();
        public Prescription chosenPrescription { get; set; }
        public LoggedUser loggedUser { get; set; }
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void perscriptionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenPrescription = prescriptionList[prescriptionsListBox.SelectedIndex];
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreatePrescription();
            createForm.loggedUser = loggedUser;
            createForm.Location = this.Location;
            createForm.StartPosition = FormStartPosition.Manual;
            createForm.FormClosing += delegate 
            {
                this.PrescriptionForm_Load(sender,e);
                this.Show(); 
            };
            createForm.Show();
            this.Hide();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            var detailsForm = new PrescriptionsDetailsForm();
            detailsForm.loggedUser = loggedUser;
            detailsForm.chosenPerscription = chosenPrescription;
            detailsForm.Location = this.Location;
            detailsForm.StartPosition = FormStartPosition.Manual;
            detailsForm.FormClosing += delegate { this.Show(); };
            detailsForm.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            //Get all users perscriptions
            prescriptionsListBox.Items.Clear();
            prescriptionList.Clear();
            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/perscriptions/user/" + loggedUser.idUser;
            rest.httpMethod = httpVerb.GET;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem with getting perscriptions");
                return;
            }
            prescriptionList = JsonConvert.DeserializeObject<List<Prescription>>(strResponse);

            foreach (Prescription element in prescriptionList)
            {
                DateTime date = DateTime.Parse(element.prescriptionDate);
                prescriptionsListBox.Items.Add(date.Day + "/" + date.Month + "/" + date.Year + " " + date.TimeOfDay);
            }
            if (prescriptionList.Count != 0)
            {
                prescriptionsListBox.SelectedIndex = 0;
                chosenPrescription = prescriptionList[0];
            }
            if(loggedUser.idUserType == 3)
            {
                createButton.Hide();
            }
        }
    }
}
