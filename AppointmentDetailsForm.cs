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

namespace DrHelperFront
{
    public partial class appointmentDetailsForm : Form
    {
        public Appointment selectedAppointment { get; set; }
        public Timeblock patientTimeblock { get; set; }
        public Timeblock doctorTimeblock { get; set; }
        public User loggedUser { get; set; }
        public User otherUser { get; set; }

        public appointmentDetailsForm()
        {
            InitializeComponent();
        }

        private void UserAppointmentDetailsForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = doctorTimeblock.startTime.Day + "/" + doctorTimeblock.startTime.Month + "/" + doctorTimeblock.startTime.Year;
            timeLabel.Text = doctorTimeblock.startTime.TimeOfDay.ToString();

            if (loggedUser.idUserType == 3)
            {
                otherUserTypeLabel.Text = "DOCTOR: ";
                otherUserLinkLabel.Text = otherUser.name + " " + otherUser.surname;
            }
            else
            {
                otherUserTypeLabel.Text = "PATIENT: ";
            }

            if (doctorTimeblock.avaliable)
            {
                if (loggedUser.idUserType == 2)
                {
                    signOrCancelButton.Hide();
                }
                else
                {
                    signOrCancelButton.Text = "SCHEDULE AN APPOINTMENT";
                }
            }
            else
            {
                otherUserLinkLabel.Text = otherUser.name + " " + otherUser.surname;
                if((loggedUser.idUserType == 3) && (loggedUser.idUser != patientTimeblock.idUser))
                {
                    signOrCancelButton.Hide();
                }
                signOrCancelButton.Text = "CANCEL AN APPOINTMENT";
            }
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (signOrCancelButton.Text == "CANCEL AN APPOINTMENT")
            {
                //Delete appointment and timeblock for patient
                //Delete appointment for doctor and change avaliability of doctors timeblock
                Rest rest = new Rest();
                rest.endPoint = "https://localhost:5001/api/timeblocks/" + patientTimeblock.idTimeblock;
                rest.httpMethod = httpVerb.DELETE;
                string strResponse;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem with cancelation.");
                    return;
                }

                Timeblock update = new Timeblock();
                update.idTimeblock = doctorTimeblock.idTimeblock;
                update.startTime = doctorTimeblock.startTime;
                update.endTime = doctorTimeblock.endTime;
                update.idUser = doctorTimeblock.idUser;
                update.idAppointment = 0;
                update.avaliable = true;

                var json = JsonConvert.SerializeObject(update);

                rest.endPoint = "https://localhost:5001/api/timeblocks/" + doctorTimeblock.idTimeblock;
                rest.httpMethod = httpVerb.PUT;
                rest.content = json;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem with cancelation.");
                    return;
                }

                rest.endPoint = "https://localhost:5001/api/appointments/" + selectedAppointment.idAppointment;
                rest.httpMethod = httpVerb.DELETE;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem with cancelation.");
                    return;
                }
                doctorTimeblock = update;
                patientTimeblock = new Timeblock();
                MessageBox.Show("Succesful cancelation.");
                this.Close();

            }
            //SCHEDULE AN APPOINTMENT
            else
            {
                //Change avaliebility of change avaliability of doctors timeblock.
                //Add timeblock and an appointment to a patient user.
                Appointment newAppointment = new Appointment();

                var json = JsonConvert.SerializeObject(newAppointment);
                string strResponse;

                Rest rest = new Rest();
                rest.endPoint = "https://localhost:5001/api/appointments";
                rest.httpMethod = httpVerb.POST;
                rest.content = json;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem with creating appointment.");
                    return;
                }
                var appointment = JsonConvert.DeserializeObject<Appointment>(strResponse);

                Timeblock timeblockUpdate = new Timeblock();
                timeblockUpdate.idTimeblock = doctorTimeblock.idTimeblock;
                timeblockUpdate.startTime = doctorTimeblock.startTime;
                timeblockUpdate.endTime = doctorTimeblock.endTime;
                timeblockUpdate.idUser = doctorTimeblock.idUser;
                timeblockUpdate.idAppointment = appointment.idAppointment;
                timeblockUpdate.avaliable = false;

                json = JsonConvert.SerializeObject(timeblockUpdate);

                rest.endPoint = "https://localhost:5001/api/timeblocks/" + doctorTimeblock.idTimeblock;
                rest.httpMethod = httpVerb.PUT;
                rest.content = json;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem with scheduling appointment.");
                    return;
                }
                doctorTimeblock = timeblockUpdate;

                Timeblock newTimeblock = new Timeblock();
                newTimeblock.startTime = doctorTimeblock.startTime;
                newTimeblock.endTime = doctorTimeblock.endTime;
                newTimeblock.idUser = loggedUser.idUser;
                newTimeblock.idAppointment = appointment.idAppointment;
                newTimeblock.avaliable = false;


                json = JsonConvert.SerializeObject(newTimeblock);

                rest.endPoint = "https://localhost:5001/api/timeblocks";
                rest.httpMethod = httpVerb.POST;
                rest.content = json;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem with scheduling appointment.");
                    return;
                }
                patientTimeblock = JsonConvert.DeserializeObject<Timeblock>(strResponse);
                MessageBox.Show("Appointent scheduled.");
                this.Close();
            }
        }

        private void otherUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Show doctor details
            if(otherUser.idUserType == 2)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
