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
    public partial class SchedulerFrom : Form
    {
        public List<Timeblock> timeblockList = new List<Timeblock>();
        public Timeblock chosenTimeblock { get; set; }

        public Timeblock otherTimeblock { get; set; }
        public User chosenDoctor { get; set; }
        public User loggedUser { get; set; }
        
        public SchedulerFrom()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox.Items.Clear();
            timeblockList.Clear();
            showTimeblocksFromRange(e.Start, e.End);
        }

        private void showTimeblocksFromRange(DateTime startTime, DateTime endTime)
        {
            Rest rest = new Rest();
            if (chosenDoctor == null)
            {
                //Get all users timeblocks
                rest.endPoint = "https://localhost:5001/api/timeblocks/user/" + loggedUser.idUser;
            }
            else
            {
                rest.endPoint = "https://localhost:5001/api/timeblocks/user/" + chosenDoctor.idUser;
            }
            rest.httpMethod = httpVerb.GET;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem showing schedule");
                return;
            }
            var appointmentsTimeblocksList = JsonConvert.DeserializeObject<List<Timeblock>>(strResponse);
            foreach (Timeblock element in appointmentsTimeblocksList)
            {
                if (element.startTime > startTime && element.endTime < endTime)
                {
                    timeblockList.Add(element);
                    listBox.Items.Add(element.startTime);
                }
            }
            if(timeblockList.Count !=0)
            {
                listBox.SelectedIndex = 0;
            }
        }


        private void details_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count != 0)
            {
                chosenTimeblock = timeblockList[listBox.SelectedIndex];
                if (chosenTimeblock.idAppointment != 0)
                {
                    //Get appointment assigned to timeblock
                    Rest rest = new Rest();
                    rest.endPoint = "https://localhost:5001/api/appointments/" + chosenTimeblock.idAppointment;
                    rest.httpMethod = httpVerb.GET;
                    string strResponse;
                    try
                    {
                        strResponse = rest.makeRequest();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Problem getting appointment.");
                        return;
                    }
                    var appointment = JsonConvert.DeserializeObject<Appointment>(strResponse);

                    //Get all timeblocks assigned to appointment
                    rest.endPoint = "https://localhost:5001/api/timeblocks/appointment/" + appointment.idAppointment;
                    rest.httpMethod = httpVerb.GET;
                    try
                    {
                        strResponse = rest.makeRequest();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Problem finding other user");
                        return;
                    }
                    var appointmentTimeblocks = JsonConvert.DeserializeObject<List<Timeblock>>(strResponse);
                    User otherUser = new User();
                    foreach (Timeblock element in appointmentTimeblocks)
                    {
                        if (element.idTimeblock != chosenTimeblock.idTimeblock)
                        {
                            otherTimeblock = element;
                        }
                    }

                    rest.endPoint = "https://localhost:5001/api/users/" + otherTimeblock.idUser;
                    rest.httpMethod = httpVerb.GET;
                    try
                    {
                        strResponse = rest.makeRequest();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Problem finding other user");
                        return;
                    }
                    otherUser = JsonConvert.DeserializeObject<User>(strResponse);

                    var detailsForm = new appointmentDetailsForm
                    {
                        selectedAppointment = appointment,
                        loggedUser = loggedUser,
                        Location = this.Location,
                        StartPosition = FormStartPosition.Manual
                    };

                    //Doctor logged in
                    if (loggedUser.idUserType == 2)
                    {
                        detailsForm.doctorTimeblock = chosenTimeblock;
                        detailsForm.patientTimeblock = otherTimeblock;
                        detailsForm.otherUser = otherUser;
                        detailsForm.FormClosing += delegate 
                        { 
                            this.chosenTimeblock = detailsForm.doctorTimeblock;
                            this.otherTimeblock = detailsForm.patientTimeblock;
                        };
                    }
                    //Patient logged in, looking at their schedule
                    else if (chosenDoctor == null)
                    {
                        detailsForm.doctorTimeblock = otherTimeblock;
                        detailsForm.patientTimeblock = chosenTimeblock;
                        detailsForm.otherUser = otherUser;
                        detailsForm.FormClosing += delegate
                        {
                            this.chosenTimeblock = detailsForm.patientTimeblock;
                            this.otherTimeblock = detailsForm.doctorTimeblock;
                        };
                    }
                    //Patient logged in, looking at doctors schedule
                    else
                    {
                        detailsForm.doctorTimeblock = chosenTimeblock;
                        detailsForm.patientTimeblock = otherTimeblock;
                        detailsForm.otherUser = chosenDoctor;
                        detailsForm.FormClosing += delegate
                        {
                            this.chosenTimeblock = detailsForm.doctorTimeblock;
                            this.otherTimeblock = detailsForm.patientTimeblock;
                        };
                    }
                    detailsForm.FormClosing += delegate 
                    {
                        this.SchedulerFrom_Load(sender, e);
                        this.Show(); 
                    };
                    detailsForm.Show();
                    this.Hide();
                }
                else
                {
                    var detailsForm = new appointmentDetailsForm
                    {
                        loggedUser = loggedUser,
                        otherUser = chosenDoctor,
                        doctorTimeblock = chosenTimeblock,
                        Location = this.Location,
                        StartPosition = FormStartPosition.Manual
                    };
                    detailsForm.FormClosing += delegate 
                    {
                        this.SchedulerFrom_Load(sender, e);
                        this.chosenTimeblock = detailsForm.doctorTimeblock;
                        this.otherTimeblock = detailsForm.patientTimeblock;
                        this.Show(); 
                    };
                    detailsForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("No timeblocks assigned to user.");
            }
        }

        private void SchedulerFrom_Load(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            timeblockList.Clear();
            showTimeblocksFromRange(monthCalendar1.SelectionStart, monthCalendar1.SelectionStart.AddDays(1));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
