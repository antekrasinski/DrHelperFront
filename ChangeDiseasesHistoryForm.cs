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
    public partial class ChangeDiseasesHistoryForm : Form
    {
        public Disease chosenDisease { get; set; }
        public UsersDiseases chosenUsersDiseases { get; set; }
        public List<Disease> allDiseases = new List<Disease>();
        public BasicUser historyUser { get; set; }
        public bool isEdit;
        public ChangeDiseasesHistoryForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Rest rest = new Rest();

            UsersDiseases toSend = new UsersDiseases();
            toSend.idDisease = allDiseases[nameComboBox.SelectedIndex].idDisease;
            toSend.idUser = historyUser.idUser;
            toSend.occurrenceDate = dateTimePicker.Value.ToString();
            toSend.description = descriptionTextBox.Text;

            var json = JsonConvert.SerializeObject(toSend);

            //PUT
            if (isEdit)
            {
                toSend.idUsersDiseases = chosenUsersDiseases.idUsersDiseases;

                rest.endPoint = "https://localhost:5001/api/usersDiseases/" + chosenUsersDiseases.idUsersDiseases;
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
                this.Close();
            }
            //POST
            else
            {
                rest.endPoint = "https://localhost:5001/api/usersDiseases";
                rest.httpMethod = httpVerb.POST;
                rest.content = json;
                string strResponse = string.Empty;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem z dołączeniem chorób.");
                    return;
                }
                this.Close();
            }
        }

        private void ChangeDiseasesHistory_Load(object sender, EventArgs e)
        {
            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/diseases";
            rest.httpMethod = httpVerb.GET;
            string strResponse = string.Empty;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem z wczytywaniem chorób.");
                return;
            }
            allDiseases = JsonConvert.DeserializeObject<List<Disease>>(strResponse);

            foreach (Disease element in allDiseases)
            {
                nameComboBox.Items.Add(element.name);
            }

            if(isEdit)
            {
                nameComboBox.SelectedIndex = nameComboBox.Items.IndexOf(chosenDisease.name);
                dateTimePicker.Value = DateTime.Parse(chosenUsersDiseases.occurrenceDate);
                descriptionTextBox.Text = chosenUsersDiseases.description;
            }
        }
    }
}
