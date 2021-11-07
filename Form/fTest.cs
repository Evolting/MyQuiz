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
    public partial class fTest : Form
    {
        Test test = new Test();
        List<Question> questions = new List<Question>();

        public fTest(Test test)
        {
            InitializeComponent();
            this.test = test;
            this.questions = test.questions;
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            cbQuestion.DataSource = questions;
            cbQuestion.DisplayMember = "ID";
            cbQuestion.ValueMember = "ID";
            rtbQuestion.Text = questions[0].q;
        }

        private void cbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            rtbQuestion.Text = questions[ID].q;
            if (questions[ID].choice != null)
            {
                cbAnswer.SelectedItem = questions[ID].choice;
            }
            else cbAnswer.SelectedIndex = -1;
        }

        private void cbAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnswer.SelectedIndex != -1)
            {
                String ans = cbAnswer.SelectedItem.ToString();
                int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
                test.questions[ID].choice = ans;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int score = 0;
            foreach (var question in questions)
            {
                if (question.choice != null)
                {
                    string selected = question.answers[question.choice];
                    if (selected.Equals(question.a)) score += 1;
                }
            }
            test.score = score;
            fResult frm = new fResult(test);
            this.Close();
            frm.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(cbQuestion.SelectedIndex.ToString());
            test.questions[ID].choice = null;
            cbAnswer.SelectedIndex = -1;
        }
    }
}
