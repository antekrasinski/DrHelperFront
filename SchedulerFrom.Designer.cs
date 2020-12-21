namespace DrHelperFront
{
    partial class SchedulerFrom
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox = new System.Windows.Forms.ListBox();
            this.details = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(457, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(23, 18);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(410, 404);
            this.listBox.TabIndex = 1;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(503, 264);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(248, 49);
            this.details.TabIndex = 2;
            this.details.Text = "DETAILS";
            this.details.UseVisualStyleBackColor = false;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(503, 319);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(248, 49);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SchedulerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.details);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "SchedulerFrom";
            this.Text = "SchedulerFrom";
            this.Load += new System.EventHandler(this.SchedulerFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button backButton;
    }
}