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
    }
}
