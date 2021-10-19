using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class fLogin : Form
    {
        DAO.UserDAO udb = new DAO.UserDAO();

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtname.Text;
                string password = mtxtpass.Text;
                if (udb.getUser(username, password) == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
                else
                {
                    MessageBox.Show("Welcome to MyQuiz!");
                    this.Hide();
                    fHome home = new fHome();
                    home.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignup signUp = new fSignup();
            signUp.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
}
