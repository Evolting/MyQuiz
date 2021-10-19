using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class fSignup : Form
    {
        DAO.UserDAO udb = new DAO.UserDAO();

        public fSignup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtName.Text;
                string password = txtPwd.Text;
                string img = txtUrl.Text;
                string email = txtMail.Text;
                if (udb.InsertUser(username, password, img, email) > 0)
                {
                    MessageBox.Show("Insert success!");
                    this.Close();
                }
                else MessageBox.Show("Insert failed!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
