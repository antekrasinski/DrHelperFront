namespace DrHelperFront
{
    partial class RegisterForm
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
            this.register = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.backToLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(492, 293);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(212, 29);
            this.register.TabIndex = 0;
            this.register.Text = "REGISTER";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(192, 108);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(230, 27);
            this.textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(192, 141);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(230, 27);
            this.textPassword.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(192, 174);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(230, 27);
            this.textName.TabIndex = 1;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(192, 207);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(230, 27);
            this.textSurname.TabIndex = 1;
            // 
            // backToLogin
            // 
            this.backToLogin.Location = new System.Drawing.Point(492, 328);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(212, 29);
            this.backToLogin.TabIndex = 0;
            this.backToLogin.Text = "BACK";
            this.backToLogin.UseVisualStyleBackColor = true;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Surname";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.register);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Button backToLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}