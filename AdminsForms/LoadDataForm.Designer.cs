namespace DrHelperFront.AdminsForms
{
    partial class LoadDataForm
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.diseasesButton = new System.Windows.Forms.Button();
            this.medicineButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATH :";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(163, 58);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(516, 27);
            this.pathTextBox.TabIndex = 1;
            // 
            // diseasesButton
            // 
            this.diseasesButton.Location = new System.Drawing.Point(163, 100);
            this.diseasesButton.Name = "diseasesButton";
            this.diseasesButton.Size = new System.Drawing.Size(168, 41);
            this.diseasesButton.TabIndex = 2;
            this.diseasesButton.Text = "LOAD DISEASES";
            this.diseasesButton.UseVisualStyleBackColor = true;
            this.diseasesButton.Click += new System.EventHandler(this.diseasesButton_Click);
            // 
            // medicineButton
            // 
            this.medicineButton.Location = new System.Drawing.Point(337, 100);
            this.medicineButton.Name = "medicineButton";
            this.medicineButton.Size = new System.Drawing.Size(168, 41);
            this.medicineButton.TabIndex = 2;
            this.medicineButton.Text = "LOAD MEDICINE";
            this.medicineButton.UseVisualStyleBackColor = true;
            this.medicineButton.Click += new System.EventHandler(this.medicineButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(511, 100);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(168, 41);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // LoadDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 204);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.medicineButton);
            this.Controls.Add(this.diseasesButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LoadDataForm";
            this.Text = "LoadDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button diseasesButton;
        private System.Windows.Forms.Button medicineButton;
        private System.Windows.Forms.Button backButton;
    }
}