using DrHelperFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront.DoctorsForms
{
    public partial class shiftForm : Form
    {
        public LoggedUser loggedUser = new LoggedUser();
        public shiftForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Shift shift = new Shift();
            shift.idUser = loggedUser.idUser;
            shift.shiftStart = dateTimePicker1.Value.ToString();
            shift.shiftEnd = dateTimePicker2.Value.ToString();
            shift.appointmentSpan = dateTimePicker3.Value.TimeOfDay.ToString();

            var json = JsonConvert.SerializeObject(shift);

            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/timeblocks/shift";
            rest.httpMethod = httpVerb.POST;
            rest.content = json;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem z tworzeniem zmiany.");
                return;
            }

            MessageBox.Show("Pomyślnie stworzono zmianę.");
        }
    }
}
