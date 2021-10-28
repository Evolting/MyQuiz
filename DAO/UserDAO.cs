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

    class UserDAO
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


        public User getUser(string username, string password)
        {
            connection = new SqlConnection(getConnectionString());
            string query = "select * from [user] where username = '"+username+"' and password = '"+password+"' ";

            command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@name", username);
            //command.Parameters.AddWithValue("@pass", password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        return new User()
                        {
                            userID = reader.GetInt32("userID"),
                            username = reader.GetString("username"),
                            password = reader.GetString("password"),
                            img = reader.GetString("img"),
                            email = reader.GetString("email"),
                            createdDate = reader.GetDateTime("createdDate").ToString(),
                            role = reader.GetInt32("role")
                        };
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

            return null ;
        }
        public int InsertUser(string username, string password, string img, string email) 
        {
            int result = 0;

            connection = new SqlConnection(getConnectionString());
            string query = "insert into [user] values(@Name, @Pwd, @Img, @Email, @Date, @Role)";
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", username);
            command.Parameters.AddWithValue("@Pwd", password);
            command.Parameters.AddWithValue("@Img", img);
            command.Parameters.AddWithValue("@Email", email);

            DateTime dateTime = DateTime.UtcNow.Date;
            command.Parameters.AddWithValue("@Date", dateTime.ToString("yyyy/MM/dd"));
            command.Parameters.AddWithValue("@Role", 1);

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
