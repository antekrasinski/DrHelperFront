namespace DrHelperFront
{
    partial class DoctorSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doctorsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.doctorsScheduleButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usersScheduleButton = new System.Windows.Forms.Button();
            this.prescriptionsButton = new System.Windows.Forms.Button();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorsList
            // 
            this.doctorsList.FormattingEnabled = true;
            this.doctorsList.ItemHeight = 20;
            this.doctorsList.Location = new System.Drawing.Point(24, 12);
            this.doctorsList.Name = "doctorsList";
            this.doctorsList.Size = new System.Drawing.Size(400, 404);
            this.doctorsList.TabIndex = 0;
            this.doctorsList.SelectedIndexChanged += new System.EventHandler(this.doctorsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IMIĘ :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(573, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "NAZWISKO :";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(573, 84);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 20);
            this.surnameLabel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "OPIS :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(573, 115);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 20);
            this.descriptionLabel.TabIndex = 1;
            // 
            // doctorsScheduleButton
            // 
            this.doctorsScheduleButton.Location = new System.Drawing.Point(460, 173);
            this.doctorsScheduleButton.Name = "doctorsScheduleButton";
            this.doctorsScheduleButton.Size = new System.Drawing.Size(297, 40);
            this.doctorsScheduleButton.TabIndex = 2;
            this.doctorsScheduleButton.Text = "TERMINARZ LEKARZA";
            this.doctorsScheduleButton.UseVisualStyleBackColor = true;
            this.doctorsScheduleButton.Click += new System.EventHandler(this.doctorsScheduleButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(460, 357);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(297, 40);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "WYLOGUJ SIĘ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // usersScheduleButton
            // 
            this.usersScheduleButton.Location = new System.Drawing.Point(460, 219);
            this.usersScheduleButton.Name = "usersScheduleButton";
            this.usersScheduleButton.Size = new System.Drawing.Size(297, 40);
            this.usersScheduleButton.TabIndex = 2;
            this.usersScheduleButton.Text = "TWÓJ TERMINARZ";
            this.usersScheduleButton.UseVisualStyleBackColor = true;
            this.usersScheduleButton.Click += new System.EventHandler(this.usersScheduleButton_Click);
            // 
            // prescriptionsButton
            // 
            this.prescriptionsButton.Location = new System.Drawing.Point(460, 265);
            this.prescriptionsButton.Name = "prescriptionsButton";
            this.prescriptionsButton.Size = new System.Drawing.Size(297, 40);
            this.prescriptionsButton.TabIndex = 2;
            this.prescriptionsButton.Text = "RECEPTY";
            this.prescriptionsButton.UseVisualStyleBackColor = true;
            this.prescriptionsButton.Click += new System.EventHandler(this.prescriptionsButton_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.Location = new System.Drawing.Point(460, 311);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(297, 40);
            this.editProfileButton.TabIndex = 2;
            this.editProfileButton.Text = "EDYTUJ PROFIL";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // DoctorSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 435);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.prescriptionsButton);
            this.Controls.Add(this.usersScheduleButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.doctorsScheduleButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorsList);
            this.Name = "DoctorSelectionForm";
            this.Text = "DrHelper";
            this.Load += new System.EventHandler(this.DoctorSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox doctorsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button doctorsScheduleButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button usersScheduleButton;
        private System.Windows.Forms.Button prescriptionsButton;
        private System.Windows.Forms.Button editProfileButton;
    }
}