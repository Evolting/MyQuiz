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
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ucSearch1.BringToFront();
        }

        private void btnMyQuiz_Click(object sender, EventArgs e)
        {
            ucMyQuiz1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            ucAboutUs1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
