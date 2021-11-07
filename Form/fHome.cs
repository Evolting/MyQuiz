using QuizApp.DAO;
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
        DAO.QuizDAO qdb = new DAO.QuizDAO();

        public fHome()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMyQuiz_Click(object sender, EventArgs e)
        {
            if (!pnMyQuiz.Controls.Contains(ucMyQuiz.Instance))
            {
                pnMyQuiz.Controls.Add(ucMyQuiz.Instance);
                ucMyQuiz.Instance.Dock = DockStyle.Fill;
                ucMyQuiz.Instance.BringToFront();
            }
            else
                ucMyQuiz.Instance.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!pnMyQuiz.Controls.Contains(ucSearch.Instance))
            {
                pnMyQuiz.Controls.Add(ucSearch.Instance);
                ucSearch.Instance.Dock = DockStyle.Fill;
                ucSearch.Instance.BringToFront();
            }
            else
                ucSearch.Instance.BringToFront();
        }
    }
}
