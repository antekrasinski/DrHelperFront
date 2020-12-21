namespace DrHelperFront
{
    partial class PrescriptionsDetailsForm
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
            this.otherUserLinkLabel = new System.Windows.Forms.LinkLabel();
            this.medicineLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.otherUserLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otherUserLinkLabel
            // 
            this.otherUserLinkLabel.AutoSize = true;
            this.otherUserLinkLabel.Location = new System.Drawing.Point(203, 81);
            this.otherUserLinkLabel.Name = "otherUserLinkLabel";
            this.otherUserLinkLabel.Size = new System.Drawing.Size(76, 20);
            this.otherUserLinkLabel.TabIndex = 1;
            this.otherUserLinkLabel.TabStop = true;
            this.otherUserLinkLabel.Text = "linkLabel2";
            this.otherUserLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.otherUserLinkLabel_LinkClicked);
            // 
            // medicineLabel
            // 
            this.medicineLabel.AutoSize = true;
            this.medicineLabel.Location = new System.Drawing.Point(203, 110);
            this.medicineLabel.Name = "medicineLabel";
            this.medicineLabel.Size = new System.Drawing.Size(0, 20);
            this.medicineLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATE :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(203, 51);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "label2";
            // 
            // otherUserLabel
            // 
            this.otherUserLabel.AutoSize = true;
            this.otherUserLabel.Location = new System.Drawing.Point(84, 81);
            this.otherUserLabel.Name = "otherUserLabel";
            this.otherUserLabel.Size = new System.Drawing.Size(71, 20);
            this.otherUserLabel.TabIndex = 0;
            this.otherUserLabel.Text = "PATIENT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "MEDICINE :";
            // 
            // PrescriptionsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.otherUserLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicineLabel);
            this.Controls.Add(this.otherUserLinkLabel);
            this.Name = "PrescriptionsDetailsForm";
            this.Text = "PrescriptionsDetailsForm";
            this.Load += new System.EventHandler(this.PrescriptionsDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel otherUserLinkLabel;
        private System.Windows.Forms.Label medicineLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label otherUserLabel;
        private System.Windows.Forms.Label label5;
    }
}