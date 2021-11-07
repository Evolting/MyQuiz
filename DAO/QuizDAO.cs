using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using QuizApp.Model;
using System.Linq;

namespace QuizApp.DAO
{


    class QuizDAO
    {
        // đối tượng kết nối
        SqlConnection connection;

        // đối tượng thực thi các truy vấn
        SqlCommand command;


        string getConnectionString()
        {
            // khai báo và lấy chuỗi từ appsettings.json
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();

            return config["ConnectionString:MyQuizDB"];
        }



        public List<QuizSet> getSetByName(string name, string criteria, string order)
        {
            List<QuizSet> sList = new List<QuizSet>();
            connection = new SqlConnection(getConnectionString());
            string query = "select quizSet.setID, userID, quizName, description, COUNT(quizID) as quizCount, createdDate, privacy " +
                "from quizSet inner join quiz on quizSet.setID = quiz.setID " +
                "where privacy = 0 and quizName like '%"+name+"%' " +
                "group by quizSet.setID, userID, quizName, description, createdDate, privacy " +
                "order by "+criteria+" "+order+" ";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@criteria", criteria);
            command.Parameters.AddWithValue("@order", order);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        QuizSet qs = new QuizSet()
                        {
                            setID = reader.GetInt32("setID"),
                            userID = reader.GetInt32("userID"),
                            quizName = reader.GetString("quizName"),
                            description = reader.GetString("description"),
                            quizCount = reader.GetInt32("quizCount"),
                            createdDate = reader.GetDateTime("createdDate"),
                            privacy = reader.GetBoolean("privacy")
                        };
                        sList.Add(qs);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return sList;
        }



        public List<QuizSet> getMySet()
        {
            List<QuizSet> sList = new List<QuizSet>();
            connection = new SqlConnection(getConnectionString());
            string query = "select quizSet.setID, userID, quizName, description, COUNT(quizID) as quizCount, createdDate, privacy " +
                " from quizSet inner join quiz on quizSet.setID = quiz.setID" +
                " where userID = 1 " +
                " group by quizSet.setID, userID, quizName, description, createdDate, privacy";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", 1);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        QuizSet qs = new QuizSet()
                        {
                            setID = reader.GetInt32("setID"),
                            userID = reader.GetInt32("userID"),
                            quizName = reader.GetString("quizName"),
                            description = reader.GetString("description"),
                            quizCount = reader.GetInt32("quizCount"),
                            createdDate = reader.GetDateTime("createdDate"),
                            privacy = reader.GetBoolean("privacy")
                        };
                        sList.Add(qs);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return sList;
        }

        
        public List<Question> createQuestions(int setID)
        {
            connection = new SqlConnection(getConnectionString());


            // lấy ra list các câu hỏi thuộc quizSet đã chọn
            List<int> quizID = new List<int>();
            string query = "select quizID from quiz where setID = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", setID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        quizID.Add(reader.GetInt32("quizID"));
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            // set up từng câu hỏi
            List<Question> questions = new List<Question>();
            for (int i = 0; i < quizID.Count; i++)
            {
                questions.Add(setUpQuestion(setID, quizID[i], i));
            }

            return questions;
        }


        public Question setUpQuestion(int setID, int quizID, int num)
        {
            Question question = new Question();
            connection = new SqlConnection(getConnectionString());


            // lấy ra câu hỏi
            string query = "select * from quiz where quizID = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", quizID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        // đặt ID
                        question.ID = num + 1;

                        // lấy câu hỏi
                        question.q = reader.GetString("term");

                        // lấy câu hỏi
                        question.quest = reader.GetString("term");

                        // lấy key
                        question.a = reader.GetString("definition");
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            // đây là các đáp án A, B, C, D sẽ hiện lên màn hình
            Dictionary<string, string> ans = new Dictionary<string, string>();
            

            // lấy ngẫu nhiên 3 câu trả lời cùng quizSet và khác với key
            List<string> others = new List<string>();
            query = "select top 3 * from quiz where setID = @setID and quizID != @ID ORDER BY NEWID()";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@setID", setID);
            command.Parameters.AddWithValue("@ID", quizID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        others.Add(reader.GetString("definition"));
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            others.Add(question.a);

            Random rng = new Random();
            var shuffle = others.OrderBy(a => rng.Next()).ToList();


            // thêm các đáp án A, B, C, D
            ans.Add("A", shuffle[0]);
            ans.Add("B", shuffle[1]);
            ans.Add("C", shuffle[2]);
            ans.Add("D", shuffle[3]);


            // ghép đáp án với đề
            question.q += ":\n\n";
            foreach(var key in ans)
            {
                question.q += $"{key.Key}. {key.Value} \n";
            }

            question.answers = ans;

            return question;
        }
    }
}
