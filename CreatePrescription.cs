using DrHelperFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrHelperFront
{
    public partial class CreatePrescription : Form
    {
        public DataGridView dataGridView = new DataGridView();
        public List<Medicine> medicineList = new List<Medicine>();
        public List<BasicUser> patientList = new List<BasicUser>();
        public LoggedUser loggedUser = new LoggedUser();
        public CreatePrescription()
        {
            InitializeComponent();
        }

        private void CreatePerscription_Load(object sender, EventArgs e)
        {
            Rest rest = new Rest();
            rest.endPoint = "http://localhost:5000/api/medicine";
            rest.httpMethod = httpVerb.GET;
            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem getting medicine.");
                return;
            }
            medicineList = JsonConvert.DeserializeObject<List<Medicine>>(strResponse);

            rest.endPoint = "http://localhost:5000/api/users";
            rest.httpMethod = httpVerb.GET;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem getting users.");
                return;
            }
            var usersList = JsonConvert.DeserializeObject<List<BasicUser>>(strResponse);
            foreach(BasicUser element in usersList)
            {
                if(element.idUserType == 3)
                {
                    patientList.Add(element);
                    patientComboBox.Items.Add(element.name + " " + element.surname);
                }
            }

            this.Controls.Add(dataGridView);

            dataGridView.Name = "dataGridView";
            dataGridView.Location = new Point(185, 110);
            dataGridView.Size = new Size(325, 200);
            dataGridView.BackgroundColor = Color.LightGray;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            DataGridViewComboBoxColumn medicineColumn = new DataGridViewComboBoxColumn();
            foreach(Medicine element in medicineList)
            {
                medicineColumn.Items.Add(element.name);
            }
            dataGridView.Columns.AddRange(medicineColumn);
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].HeaderText = "MEDICINE";
            dataGridView.Columns[1].HeaderText = "AMOUNT";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Prescription newPerscription = new Prescription();
            newPerscription.prescriptionDate = dateTimePicker1.Value.ToString();

            var json = JsonConvert.SerializeObject(newPerscription);

            Rest rest = new Rest();
            rest.endPoint = "http://localhost:5000/api/perscriptions";
            rest.httpMethod = httpVerb.POST;
            rest.content = json;

            string strResponse;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem creating perscription.");
                return;
            }
            newPerscription = JsonConvert.DeserializeObject<Prescription>(strResponse);

            //Connecting perscription to patient
            UsersPrescriptions newUserConnection = new UsersPrescriptions();
            newUserConnection.idPrescription = newPerscription.idPrescription;
            newUserConnection.idUser = patientList[patientComboBox.SelectedIndex].idUser;

            json = JsonConvert.SerializeObject(newUserConnection);

            rest.endPoint = "http://localhost:5000/api/perscriptions/user";
            rest.httpMethod = httpVerb.POST;
            rest.content = json;

            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem connecting user to perscription.");
                return;
            }

            //Connecting perscription to doctor
            newUserConnection.idUser = loggedUser.idUser;

            json = JsonConvert.SerializeObject(newUserConnection);

            rest.endPoint = "http://localhost:5000/api/perscriptions/user";
            rest.httpMethod = httpVerb.POST;
            rest.content = json;

            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem connecting user to perscription.");
                return;
            }

            PrescriptionsMedicine newMedicineConnection;
            int idMedicine = 0;
            for(int i=0; i<(dataGridView.Rows.Count - 1); i++)
            {
                newMedicineConnection = new PrescriptionsMedicine();
                newMedicineConnection.idPrescription = newPerscription.idPrescription;

                foreach(Medicine element in medicineList)
                {
                    if (element.name == dataGridView.Rows[i].Cells[0].Value.ToString())
                        idMedicine = element.idMedicine;
                }
                newMedicineConnection.idMedicine = idMedicine;
                newMedicineConnection.amount = dataGridView.Rows[i].Cells[1].Value.ToString();

                json = JsonConvert.SerializeObject(newMedicineConnection);

                rest.endPoint = "http://localhost:5000/api/perscriptions/medicine";
                rest.httpMethod = httpVerb.POST;
                rest.content = json;

                try
                {
                    strResponse = rest.makeRequest();
                }
                catch (Exception es)
                {
                    MessageBox.Show("Problem connecting medicine to perscription.");
                    return;
                }
            }
            MessageBox.Show("Succesfuly created prescription.");
            this.Close();
        }
    }
}
