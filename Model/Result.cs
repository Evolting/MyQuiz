using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Model
{
    class Result
    {
        public int ID { get; set; }
        public string question { get; set; }
        public string selected { get; set; }
        public string answer { get; set; }
        public int mark { get; set; }
    }
}
