using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Model
{
    class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string img { get; set; }
        public string email { get; set; }
        public string createdDate { get; set; }
        public int role { get; set; }
    }
}
