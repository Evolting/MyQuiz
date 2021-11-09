using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Model
{
    class QuizSet
    {
        public int setID { get; set; }
        public int userID { get; set; }
        public string quizName { get; set; }
        public string description { get; set; }
        public int quizCount { get; set; }
        public DateTime createdDate { get; set; }
        public bool privacy { get; set; }

      
    }
}
