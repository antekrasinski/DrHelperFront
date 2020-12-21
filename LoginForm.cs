﻿using DrHelperFront.DoctorsForms;
using DrHelperFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrHelperFront
{
    public partial class LoginForm : Form
    {
        User loggedUser { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.username = loginTextBox.Text;
            signIn.password = passwordTextBox.Text;

            var json = JsonConvert.SerializeObject(signIn);

            Rest rest = new Rest();
            rest.endPoint = "https://localhost:5001/api/users/authenticate";
            rest.httpMethod = httpVerb.POST;
            rest.content = json;

            string strResponse = string.Empty;
            try
            {
                strResponse = rest.makeRequest();
            }
            catch (Exception es)
            {
                MessageBox.Show("Problem with logging into system.");
                return;
            }

            loggedUser = JsonConvert.DeserializeObject<User>(strResponse);
            //Admin logged in
            if (loggedUser.idUserType == 1)
            {

            }
            //Doctor logged in
            else if (loggedUser.idUserType == 2)
            {
                //Show doctors menu
                var doctorsMenuForm = new DoctorsMenuForm();
                doctorsMenuForm.loggedUser = loggedUser;
                doctorsMenuForm.Location = this.Location;
                doctorsMenuForm.StartPosition = FormStartPosition.Manual;
                doctorsMenuForm.FormClosing += delegate { this.Show(); };
                doctorsMenuForm.Show();
                this.Hide();
            }
            //Patient logged in
            else
            {
                //Show list of doctors
                var docSelectForm = new DoctorSelectionForm();
                docSelectForm.loggedUser = loggedUser;
                docSelectForm.Location = this.Location;
                docSelectForm.StartPosition = FormStartPosition.Manual;
                docSelectForm.FormClosing += delegate { this.Show(); };
                docSelectForm.Show();
                this.Hide();
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Location = this.Location;
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.FormClosing += delegate { this.Show(); };
            registerForm.Show();
            this.Hide();
        }
    }
}