namespace DrHelperFront.DoctorsForms
{
    partial class PatientProfileForm
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
            this.historyButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(462, 39);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(199, 39);
            this.historyButton.TabIndex = 1;
            this.historyButton.Text = "SHOW DISEASES HISTORY";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(462, 90);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(199, 38);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(204, 87);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(50, 20);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "SURNAME : ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(204, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "NAME : ";
            // 
            // PatientProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.historyButton);
            this.Name = "PatientProfileForm";
            this.Text = "PatientProfileForm";
            this.Load += new System.EventHandler(this.PatientProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label6;
    }
}