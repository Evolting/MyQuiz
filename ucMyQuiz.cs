using QuizApp.DAO;
using QuizApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ucMyQuiz : UserControl
    {
        QuizDAO qdb = new QuizDAO();

        private static ucMyQuiz _instance;
        public static ucMyQuiz Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMyQuiz();
                return _instance;
            }
        }
        public ucMyQuiz()
        {
            InitializeComponent();
            Reload();
        }

        void Reload()
        {
            dgvMyQuiz.DataSource = null;
            List<QuizSet> quizSets = qdb.getMySet();
            dgvMyQuiz.DataSource = quizSets;
            dgvMyQuiz.Columns[1].Visible = false;
            dgvMyQuiz.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ucMyQuiz_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creating!", "Confirm", MessageBoxButtons.YesNo);
        }
    }
}
