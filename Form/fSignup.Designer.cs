
namespace QuizApp
{
    partial class fSignup
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
            this.title = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(126, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Sign Up";
            // 
            // username
            // 
            this.username.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(45, 88);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(75, 20);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(44, 152);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Location = new System.Drawing.Point(45, 218);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(82, 20);
            this.fullname.TabIndex = 3;
            this.fullname.Text = "Avatar URL";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(45, 281);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 20);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(45, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 27);
            this.txtName.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(45, 175);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(272, 27);
            this.txtPwd.TabIndex = 6;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(44, 241);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(273, 27);
            this.txtUrl.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(45, 305);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(272, 27);
            this.txtMail.TabIndex = 8;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(45, 373);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(94, 29);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExit.Location = new System.Drawing.Point(223, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 431);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.email);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.title);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}