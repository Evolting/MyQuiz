
namespace QuizApp
{
    partial class fHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnMyQuiz = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucAboutUs1 = new QuizApp.ucAboutUs();
            this.ucHome1 = new QuizApp.ucHome();
            this.ucMyQuiz1 = new QuizApp.ucMyQuiz();
            this.ucSearch1 = new QuizApp.ucSearch();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnAboutUs);
            this.panel1.Controls.Add(this.btnMyQuiz);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(31, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 288);
            this.panel1.TabIndex = 1;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 189);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(94, 29);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Location = new System.Drawing.Point(12, 247);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(94, 29);
            this.btnAboutUs.TabIndex = 3;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnMyQuiz
            // 
            this.btnMyQuiz.Location = new System.Drawing.Point(12, 133);
            this.btnMyQuiz.Name = "btnMyQuiz";
            this.btnMyQuiz.Size = new System.Drawing.Size(94, 29);
            this.btnMyQuiz.TabIndex = 2;
            this.btnMyQuiz.Text = "My Quiz";
            this.btnMyQuiz.UseVisualStyleBackColor = true;
            this.btnMyQuiz.Click += new System.EventHandler(this.btnMyQuiz_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 29);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(43, 740);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "MyQuiz!";
            // 
            // ucAboutUs1
            // 
            this.ucAboutUs1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucAboutUs1.Location = new System.Drawing.Point(179, 78);
            this.ucAboutUs1.Name = "ucAboutUs1";
            this.ucAboutUs1.Size = new System.Drawing.Size(1195, 691);
            this.ucAboutUs1.TabIndex = 5;
            // 
            // ucHome1
            // 
            this.ucHome1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucHome1.Location = new System.Drawing.Point(179, 78);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1195, 691);
            this.ucHome1.TabIndex = 6;
            // 
            // ucMyQuiz1
            // 
            this.ucMyQuiz1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucMyQuiz1.Location = new System.Drawing.Point(179, 78);
            this.ucMyQuiz1.Name = "ucMyQuiz1";
            this.ucMyQuiz1.Size = new System.Drawing.Size(1195, 691);
            this.ucMyQuiz1.TabIndex = 7;
            // 
            // ucSearch1
            // 
            this.ucSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucSearch1.Location = new System.Drawing.Point(179, 78);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(1195, 691);
            this.ucSearch1.TabIndex = 8;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 803);
            this.Controls.Add(this.ucHome1);
            this.Controls.Add(this.ucAboutUs1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucSearch1);
            this.Controls.Add(this.ucMyQuiz1);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyQuiz 0.5";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnMyQuiz;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfile;
        private ucAboutUs ucAboutUs1;
        private ucHome ucHome1;
        private ucMyQuiz ucMyQuiz1;
        private ucSearch ucSearch1;
    }
}

