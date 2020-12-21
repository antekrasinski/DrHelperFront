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
    public partial class RegisterForm : Form
    {
        public bool isAdmin = false;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            User newOne = new User();
            newOne.username = textUsername.Text;
            newOne.password = textPassword.Text;
            newOne.name = textName.Text;
            newOne.surname = textSurname.Text;
            newOne.idUserType = 3;
            
            if (isAdmin)
            {
                newOne.idUserType = 2;
                newOne.description = descriptionTextBox.Text;
            }
            var json = JsonConvert.SerializeObject(newOne);

            Rest rest = new Rest();
            rest.endPoint = "http://localhost:5000/api/users";
            rest.httpMethod = httpVerb.POST;
            rest.content = json;

            string strResponse = string.Empty;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch(Exception es)
            {
                MessageBox.Show("Wystapil problem z rejestracja");
                return;
            }
            MessageBox.Show("SUCCESS!");
            if (!isAdmin)
            {
                var docSelectForm = new DoctorSelectionForm();
                docSelectForm.loggedUser = newOne;
                docSelectForm.Location = this.Location;
                docSelectForm.StartPosition = FormStartPosition.Manual;
                docSelectForm.Show();
            }
            this.Close();
        }        
        
        private void backToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            if(!isAdmin)
            {
                descriptionLabel.Hide();
                descriptionTextBox.Hide();
            }
        }
    }
}
