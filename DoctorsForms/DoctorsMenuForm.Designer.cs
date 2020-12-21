namespace DrHelperFront.DoctorsForms
{
    partial class DoctorsMenuForm
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
            this.scheduleButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.prescriptionsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scheduleButton
            // 
            this.scheduleButton.Location = new System.Drawing.Point(181, 78);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(199, 79);
            this.scheduleButton.TabIndex = 0;
            this.scheduleButton.Text = "SCHEDULE";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(181, 163);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(199, 79);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "EDIT PROFILE";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // prescriptionsButton
            // 
            this.prescriptionsButton.Location = new System.Drawing.Point(386, 78);
            this.prescriptionsButton.Name = "prescriptionsButton";
            this.prescriptionsButton.Size = new System.Drawing.Size(199, 79);
            this.prescriptionsButton.TabIndex = 0;
            this.prescriptionsButton.Text = "PRESCRIPTIONS";
            this.prescriptionsButton.UseVisualStyleBackColor = true;
            this.prescriptionsButton.Click += new System.EventHandler(this.perscriptionsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(386, 163);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(199, 79);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // DoctorsMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 336);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.prescriptionsButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.scheduleButton);
            this.Name = "DoctorsMenuForm";
            this.Text = "DoctorsMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button prescriptionsButton;
        private System.Windows.Forms.Button logoutButton;
    }
}