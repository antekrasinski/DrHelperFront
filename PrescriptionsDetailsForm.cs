﻿using DrHelperFront.DoctorsForms;
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
    public partial class PrescriptionsDetailsForm : Form
    {
        public LoggedUser loggedUser { get; set; }
        public BasicUser otherUser { get; set; }
        public Prescription chosenPerscription { get; set; }
        public PrescriptionsDetailsForm()
        {
            InitializeComponent();
        }

        private void PrescriptionsDetailsForm_Load(object sender, EventArgs e)
        {
            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/perscriptions/medicine/" + chosenPerscription.idPrescription;
            rest.httpMethod = httpVerb.GET;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem z wczytywaniem leków.");
                return;
            }
            List<Medicine> medicineList = JsonConvert.DeserializeObject<List<Medicine>>(strResponse);

            foreach (Medicine element in medicineList)
            {
                rest.endPoint = "https://localhost:5001/api/perscriptions/medicine/" + chosenPerscription.idPrescription + "/" + element.idMedicine;
                rest.httpMethod = httpVerb.GET;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem z pobieraniem leków.");
                    return;
                }
                var connection = JsonConvert.DeserializeObject<dynamic>(strResponse);
                medicineListBox.Items.Add(element.name + " (" + connection.amount + ")");
            }

            rest.endPoint = "https://localhost:5001/api/perscriptions/users/" + chosenPerscription.idPrescription;
            rest.httpMethod = httpVerb.GET;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem z pobieraniem leków.");
                return;
            }
            var connectionsList = JsonConvert.DeserializeObject<List<UsersPrescriptions>>(strResponse);
            int otherUserId = 0;
            foreach (UsersPrescriptions element in connectionsList)
            {
                if(element.idUser != loggedUser.idUser)
                {
                    otherUserId = element.idUser;
                }
            }

            if (otherUserId != 0)
            {
                rest.endPoint = "https://localhost:5001/api/users/" + otherUserId;
                rest.httpMethod = httpVerb.GET;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem z pobieraniem leków.");
                    return;
                }
                otherUser = JsonConvert.DeserializeObject<BasicUser>(strResponse);

                if (otherUser.idUserType == 2)
                {
                    otherUserLabel.Text = "LEKARZ :";
                }
                else
                {
                    otherUserLabel.Text = "PACJENT :";
                }
                otherUserLinkLabel.Text = otherUser.name + " " + otherUser.surname;
                DateTime date = DateTime.Parse(chosenPerscription.prescriptionDate);
                dateLabel.Text = date.Day + "/" + date.Month + "/" + date.Year + " " + date.TimeOfDay;
            }
        }

        private void otherUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Show doctor details
            if (otherUser.idUserType == 2)
            {
                var docProfileForm = new DoctorProfileForm();
                docProfileForm.loggedUser = loggedUser;
                docProfileForm.doctorUser = otherUser;
                docProfileForm.Location = this.Location;
                docProfileForm.StartPosition = FormStartPosition.Manual;
                docProfileForm.FormClosing += delegate { this.Show(); };
                docProfileForm.Show();
                this.Hide();
            }
            //Show patients details
            else
            {
                var patientProfileForm = new PatientProfileForm();
                patientProfileForm.loggedUser = loggedUser;
                patientProfileForm.patientUser = otherUser;
                patientProfileForm.Location = this.Location;
                patientProfileForm.StartPosition = FormStartPosition.Manual;
                patientProfileForm.FormClosing += delegate { this.Show(); };
                patientProfileForm.Show();
                this.Hide();
            }
        }
    }
}
