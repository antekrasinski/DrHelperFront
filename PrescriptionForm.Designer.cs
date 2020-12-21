namespace DrHelperFront
{
    partial class PrescriptionForm
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
            this.prescriptionsListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prescriptionsListBox
            // 
            this.prescriptionsListBox.FormattingEnabled = true;
            this.prescriptionsListBox.ItemHeight = 20;
            this.prescriptionsListBox.Location = new System.Drawing.Point(34, 23);
            this.prescriptionsListBox.Name = "prescriptionsListBox";
            this.prescriptionsListBox.Size = new System.Drawing.Size(400, 404);
            this.prescriptionsListBox.TabIndex = 0;
            this.prescriptionsListBox.SelectedIndexChanged += new System.EventHandler(this.perscriptionListBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(470, 368);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(297, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(470, 276);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(297, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "CREATE PRESCRIPTION";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(470, 322);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(297, 40);
            this.detailsButton.TabIndex = 2;
            this.detailsButton.Text = "DETAILS";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.prescriptionsListBox);
            this.Name = "PrescriptionForm";
            this.Text = "PrescriptionForm";
            this.Load += new System.EventHandler(this.PrescriptionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox prescriptionsListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button detailsButton;
    }
}