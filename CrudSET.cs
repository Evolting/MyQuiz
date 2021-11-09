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
    public partial class CrudSET : Form
    {
        QuizSetDAO qsdb = new QuizSetDAO();
        public CrudSET()
        {
            InitializeComponent();
        }

        private void CrudSET_Load(object sender, EventArgs e)
        {
            //txtName.Text = fh.userID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DateTime dateTime = DateTime.Now;
            //try
            //{
            //    var quizSet = new QuizSet()
            //    {
            //        userID = fh.userID,
            //        quizName = txtName.Text,
            //        description = rtxtDesc.Text,
            //        quizCount = 0,
            //        createdDate = dateTime,
            //        privacy = cbPrivacy.Checked 
                    
            //    };
            //    if (qsdb.inserQuizset(quizSet) > 0)
            //    {
            //        MessageBox.Show("Insert success.");
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Insert failed");
            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Error");
            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
