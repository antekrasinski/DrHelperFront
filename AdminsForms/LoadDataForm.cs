using DrHelperFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront.AdminsForms
{
    public partial class LoadDataForm : Form
    {
        public LoadDataForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void medicineButton_Click(object sender, EventArgs e)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(pathTextBox.Text);
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem with opening file.");
                return;
            }
            Rest rest = new Rest();
            string strResponse;

            foreach (string element in lines)
            {
                Medicine newOne = new Medicine();
                newOne.name = element;

                string json = JsonConvert.SerializeObject(newOne);

                rest.endPoint = "http://localhost:5000/api/medicine";
                rest.httpMethod = httpVerb.POST;
                rest.content = json;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem adding medicine.");
                    return;
                }
            }
        }

        private void diseasesButton_Click(object sender, EventArgs e)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(pathTextBox.Text);
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem with opening file.");
                return;
            }

            Rest rest = new Rest();
            string strResponse;

            foreach(string element in lines)
            {
                Disease newOne = new Disease();
                newOne.name = element;

                string json = JsonConvert.SerializeObject(newOne);

                rest.endPoint = "http://localhost:5000/api/diseases";
                rest.httpMethod = httpVerb.POST;
                rest.content = json;
                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem adding disease.");
                    return;
                }
            }

        }
    }
}
