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
    public partial class DiseasesHistoryForm : Form
    {
        public User historyUser { get; set; }
        public Disease chosenDisease { get; set; }
        public UsersDiseases chosenUsersDiseases { get; set; }

        List<Disease> diseasesList = new List<Disease>();
        List<UsersDiseases> usersDiseasesList = new List<UsersDiseases>();
        public DiseasesHistoryForm()
        {
            InitializeComponent();
        }

        private void DiseasesHistoryForm_Load(object sender, EventArgs e)
        {
            diseasesListBox.Items.Clear();
            diseasesList.Clear();
            usersDiseasesList.Clear();

            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/usersDiseases/user/"+historyUser.idUser;
            rest.httpMethod = httpVerb.GET;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem loading diseases.");
                return;
            }
            var usersDiseases = JsonConvert.DeserializeObject<List<UsersDiseases>>(strResponse);
            Disease disease;
            //Get disease for each userDisease
            foreach (UsersDiseases element in usersDiseases)
            {
                rest.endPoint = "https://localhost:5001/api/diseases/" + element.idDisease;
                rest.httpMethod = httpVerb.GET;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem with finding disease");
                    return;
                }
                disease = new Disease();
                disease = JsonConvert.DeserializeObject<Disease>(strResponse);

                diseasesList.Add(disease);
                diseasesListBox.Items.Add(disease.name);

                usersDiseasesList.Add(element);
            }

            if (diseasesListBox.Items.Count != 0)
            {
                diseasesListBox.SelectedIndex = 0;
                chosenDisease = diseasesList[0];
                chosenUsersDiseases = usersDiseasesList[0];

                nameLabel.Text = chosenDisease.name;
                DateTime date = DateTime.Parse(chosenUsersDiseases.occurrenceDate);
                dateLabel.Text = date.Day+ "/" + date.Month + "/" + date.Year;
                descriptionLabel.Text = chosenUsersDiseases.description;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (diseasesListBox.SelectedIndex != -1)
            {
                chosenDisease = diseasesList[diseasesListBox.SelectedIndex];
                chosenUsersDiseases = usersDiseasesList[diseasesListBox.SelectedIndex];

                nameLabel.Text = chosenDisease.name;
                DateTime date = DateTime.Parse(chosenUsersDiseases.occurrenceDate);
                dateLabel.Text = date.Day + "/" + date.Month + "/" + date.Year;
                descriptionLabel.Text = chosenUsersDiseases.description;
            }
            else
            {
                nameLabel.Text = "";
                dateLabel.Text = "";
                descriptionLabel.Text = "";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDiseaseToHistoryButton_Click(object sender, EventArgs e)
        {
            var changeHistoryForm = new ChangeDiseasesHistoryForm();
            changeHistoryForm.historyUser = historyUser;
            changeHistoryForm.isEdit = false;
            changeHistoryForm.Location = this.Location;
            changeHistoryForm.StartPosition = FormStartPosition.Manual;
            changeHistoryForm.FormClosing += delegate 
            {
                this.DiseasesHistoryForm_Load(sender, e);
                this.Show(); 
            };
            changeHistoryForm.Show();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (diseasesListBox.SelectedIndex != -1)
            {
                var changeHistoryForm = new ChangeDiseasesHistoryForm();
                changeHistoryForm.chosenDisease = chosenDisease;
                changeHistoryForm.chosenUsersDiseases = chosenUsersDiseases;
                changeHistoryForm.historyUser = historyUser;
                changeHistoryForm.isEdit = true;
                changeHistoryForm.Location = this.Location;
                changeHistoryForm.StartPosition = FormStartPosition.Manual;
                changeHistoryForm.FormClosing += delegate
                {
                    this.DiseasesHistoryForm_Load(sender, e);
                    this.Show();
                };
                changeHistoryForm.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (diseasesListBox.SelectedIndex != -1)
            {
                Rest rest = new Rest();
                rest.endPoint = "http://localhost:5000/api/usersDiseases/" + usersDiseasesList[diseasesListBox.SelectedIndex].idUsersDiseases;
                rest.httpMethod = httpVerb.DELETE;
                string strResponse = string.Empty;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem removing connection.");
                    return;
                }

                int selected = diseasesListBox.SelectedIndex;
                diseasesListBox.Items.RemoveAt(selected);
                diseasesList.RemoveAt(selected);
                usersDiseasesList.RemoveAt(selected);
            }
        }
    }
}
