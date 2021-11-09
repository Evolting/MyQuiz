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
    class QuizSetDAO
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

        public int inserQuizset(QuizSet quizSet)
        {
            int result = 0;
            connection = new SqlConnection(getConnectionString());
            string sql = " insert into quizSet (userID, quizName, description, quizCount, createdDate, privacy) " +
                "values(@userID, @quizName, @description,@quizCount, @createdDate,@privacy)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@userID", quizSet.userID);
            command.Parameters.AddWithValue("@quizName", quizSet.quizName);
            command.Parameters.AddWithValue("@description", quizSet.description);
            command.Parameters.AddWithValue("@quizCount", quizSet.quizCount);
            command.Parameters.AddWithValue("@createdDate", quizSet.createdDate);

            command.Parameters.AddWithValue("@privacy", quizSet.privacy.ToString());

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

    }
}
