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
    public partial class CRUD : Form
    {
        QuizDAO db = new QuizDAO();
        int setID;
        public CRUD(int setID)
        {
            InitializeComponent();
            this.setID = setID;
        }

        public void Reload()
        {

            List<Quiz> list = db.getQuizbySetID(setID);
            txtSetID.DataBindings.Clear();
            txtQuizNo.DataBindings.Clear();
            txtQuiz.DataBindings.Clear();
            rtxtDefe.DataBindings.Clear();
            txtSetID.DataBindings.Add("Text", list, "setID");
            txtQuiz.DataBindings.Add("Text", list, "term");
            rtxtDefe.DataBindings.Add("Text", list, "definition");
            dgvCrudQ.DataSource = list;


        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var quiz = new Quiz()
                {
                    setID = Int32.Parse(txtSetID.Text),
                    term = txtQuiz.Text,
                    definition = rtxtDefe.Text
                };
                if (db.inserQuiz(quiz)>0)
                {
                    MessageBox.Show("Insert success.");
                    Reload();
                }
                else
                {
                    MessageBox.Show("Insert failed");
                }

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var quiz = new Quiz()
                {
                    quizID =Int32.Parse( dgvCrudQ.CurrentRow.Cells[0].Value.ToString()),
                    setID = Int32.Parse( txtSetID.Text),
                    term = txtQuiz.Text,
                    definition = rtxtDefe.Text
                };

                if (db.UpdateQuiz(quiz) > 0)
                {
                    MessageBox.Show("Update success.");
                    Reload();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var quiz = new Quiz()
                    {
                        quizID = Int32.Parse(dgvCrudQ.CurrentRow.Cells[0].Value.ToString())
                        
                    };

                    if (db.DeleteQuiz(quiz) > 0)
                    {
                        MessageBox.Show("Delete success.");
                        Reload();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
