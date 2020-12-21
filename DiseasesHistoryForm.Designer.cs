namespace DrHelperFront
{
    partial class DiseasesHistoryForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diseasesListBox = new System.Windows.Forms.ListBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(470, 322);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(297, 40);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "DELETE DISEASE FROM HISTORY";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(470, 368);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(297, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(470, 230);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(297, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "ADD DISEASE TO HISTORY";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addDiseaseToHistoryButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(611, 121);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 20);
            this.descriptionLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPTION :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "OCCURANCE DATE :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(611, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "NAME :";
            // 
            // diseasesListBox
            // 
            this.diseasesListBox.FormattingEnabled = true;
            this.diseasesListBox.ItemHeight = 20;
            this.diseasesListBox.Location = new System.Drawing.Point(34, 23);
            this.diseasesListBox.Name = "diseasesListBox";
            this.diseasesListBox.Size = new System.Drawing.Size(400, 404);
            this.diseasesListBox.TabIndex = 0;
            this.diseasesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(611, 92);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 20);
            this.dateLabel.TabIndex = 1;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(470, 276);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(297, 40);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "EDIT DISEASE FROM HISTORY";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // DiseasesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.diseasesListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Name = "DiseasesHistoryForm";
            this.Text = "DiseasesHistoryForm";
            this.Load += new System.EventHandler(this.DiseasesHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox diseasesListBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button editButton;
    }
}