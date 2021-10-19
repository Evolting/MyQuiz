
namespace QuizApp
{
    partial class fLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.mtxtpass = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(47, 207);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(204, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtname.Location = new System.Drawing.Point(47, 78);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(251, 27);
            this.txtname.TabIndex = 3;
            // 
            // mtxtpass
            // 
            this.mtxtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtpass.Location = new System.Drawing.Point(47, 152);
            this.mtxtpass.Name = "mtxtpass";
            this.mtxtpass.Size = new System.Drawing.Size(251, 27);
            this.mtxtpass.TabIndex = 4;
            this.mtxtpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Location = new System.Drawing.Point(52, 254);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(246, 20);
            this.linkSignUp.TabIndex = 7;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Don\'t have an account? Signup here";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 295);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyQuiz 0.5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.MaskedTextBox mtxtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}