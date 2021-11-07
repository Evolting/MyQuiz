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
    public partial class fResult : Form
    {
        Test test = new Test();

        public fResult(Test test)
        {
            InitializeComponent();
            this.test = test;
        }

        private void fResult_Load(object sender, EventArgs e)
        {
            txtScore.Text = test.score.ToString();
            List<Result> results = new List<Result>();
            foreach(var q in test.questions)
            {
                Result result = new Result() {
                    ID = q.ID,
                    question = q.quest,
                    answer = q.a,
                    selected = "None",
                    mark = 0
                };
                if (q.choice != null) result.selected = q.answers[q.choice];
                if (result.selected.Equals(result.answer)) result.mark = 1;
                results.Add(result);
            }
            dgvResult.DataSource = results;
        }
    }
}
