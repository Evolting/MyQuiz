using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using QuizApp.Model;

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
            string query = "select quizSet.setID, userID, quizName, description, createdDate, privacy " +
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
                            quizCount =  countQuiz(reader.GetInt32("setID")),
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
            string query = "select quizSet.setID, userID, quizName, description, createdDate, privacy " +
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
                            quizCount = countQuiz(reader.GetInt32("setID")),
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


        public List<Quiz> getQuizbySetID(int setID)
        {
            List<Quiz> listq = new List<Quiz>();
            connection = new SqlConnection(getConnectionString());
            string query = " select * from quiz where setID = " +setID;
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@setID", setID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Quiz q = new Quiz
                        {
                            quizID = reader.GetInt32("quizID"),
                            setID = reader.GetInt32("setID"),
                            term = reader.GetString("term"),
                            definition = reader.GetString("definition")
                        };
                        listq.Add(q);
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

            return listq;
        }

       public int inserQuiz (Quiz quiz)
        {
            int result = 0;
            connection = new SqlConnection(getConnectionString());
            string sql = " insert into quiz (setID, term, definition) values(@setID,@term, @definition)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@setID", quiz.setID);
            command.Parameters.AddWithValue("@term", quiz.term);
            command.Parameters.AddWithValue("@definition", quiz.definition);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public int UpdateQuiz(Quiz quiz)
        {
            int result = 0;
            connection = new SqlConnection(getConnectionString());
            string sql = " update quiz set term = @term, definition = @def where quizID = @quizID";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@quizID", quiz.quizID);
            command.Parameters.AddWithValue("@term", quiz.term);
            command.Parameters.AddWithValue("@def", quiz.definition);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public int DeleteQuiz(Quiz quiz)
        {
            int result = 0;
            connection = new SqlConnection(getConnectionString());
            string sql = " delete quiz where quizID = @quizID";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@quizID", quiz.quizID);
           
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }
       
        public int countQuiz(int setID)
        {
            int result = 0;
            connection = new SqlConnection(getConnectionString());
            string sql = "  select count(*) as QCount from quiz where setID = @setID";
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@setID", setID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                       return reader.GetInt32("QCount");
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

            return result;
        }

    }
}
