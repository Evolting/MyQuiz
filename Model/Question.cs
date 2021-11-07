using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Model
{
    public class Question
    {
        public int ID { get; set; }
        public string q { get; set; }
        public Dictionary<string, string> answers { get; set; }
        public string choice { get; set; }
        public string a { get; set; }

        public string quest { get; set; }
    }
}
