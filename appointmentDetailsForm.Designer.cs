namespace DrHelperFront
{
    partial class appointmentDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.otherUserTypeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.otherUserLinkLabel = new System.Windows.Forms.LinkLabel();
            this.signOrCancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATE :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(192, 44);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 20);
            this.dateLabel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIME :";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(192, 74);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 20);
            this.timeLabel.TabIndex = 0;
            // 
            // otherUserTypeLabel
            // 
            this.otherUserTypeLabel.AutoSize = true;
            this.otherUserTypeLabel.Location = new System.Drawing.Point(73, 106);
            this.otherUserTypeLabel.Name = "otherUserTypeLabel";
            this.otherUserTypeLabel.Size = new System.Drawing.Size(74, 20);
            this.otherUserTypeLabel.TabIndex = 0;
            this.otherUserTypeLabel.Text = "DOCTOR :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(192, 135);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 20);
            this.descriptionLabel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "DESCRIPTION :";
            // 
            // otherUserLinkLabel
            // 
            this.otherUserLinkLabel.AutoSize = true;
            this.otherUserLinkLabel.Location = new System.Drawing.Point(192, 106);
            this.otherUserLinkLabel.Name = "otherUserLinkLabel";
            this.otherUserLinkLabel.Size = new System.Drawing.Size(0, 20);
            this.otherUserLinkLabel.TabIndex = 1;
            this.otherUserLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.otherUserLinkLabel_LinkClicked);
            // 
            // signOrCancelButton
            // 
            this.signOrCancelButton.Location = new System.Drawing.Point(403, 44);
            this.signOrCancelButton.Name = "signOrCancelButton";
            this.signOrCancelButton.Size = new System.Drawing.Size(276, 51);
            this.signOrCancelButton.TabIndex = 2;
            this.signOrCancelButton.Text = "CANCEL APPOINTMENT";
            this.signOrCancelButton.UseVisualStyleBackColor = true;
            this.signOrCancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(403, 101);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(276, 55);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // appointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 205);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.signOrCancelButton);
            this.Controls.Add(this.otherUserLinkLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.otherUserTypeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Name = "appointmentDetailsForm";
            this.Text = "UserAppointmentDetailsForm";
            this.Load += new System.EventHandler(this.UserAppointmentDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label otherUserTypeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel otherUserLinkLabel;
        private System.Windows.Forms.Button signOrCancelButton;
        private System.Windows.Forms.Button backButton;
    }
}