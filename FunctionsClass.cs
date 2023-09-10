using System;
using System.Data;
using System.Data.SqlClient;

namespace airline_reservation_system
{
    class FunctionsClass
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TIjoe\source\курсач\project1.1\DataBase\ReservationDb.mdf;Integrated Security=True";
        public int ID;
        public int checkSeatTaken(int id, string seat)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM Билеты WHERE Идентификатор_маршрута = '"+id+"' and Место_в_салоне = '"+seat+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int reservationExist = (int)command.ExecuteScalar();

            if (reservationExist > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int checkMailTaken(string mail)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM Пользователи WHERE Почта = @mail";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value =  mail;

            connection.Open();
            int reservationExist = (int)command.ExecuteScalar();
            connection.Close();

            if (reservationExist > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int checkUserTaken(string uName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM Пользователи WHERE Логин = @username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value =  uName;

            connection.Open();
            int reservationExist = (int)command.ExecuteScalar();
            connection.Close();

            if (reservationExist > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int validateLogin(string uName, string pass)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT Тип_пользователя FROM Пользователи WHERE Логин = @username AND Пароль = @password", connection);
            SqlCommand command2 = new SqlCommand("SELECT Идентификатор_пользователя FROM Пользователи WHERE Логин = @username AND Пароль = @password", connection);
            string returnValue = "";


            connection.Open();

            command.Parameters.Add("@username", SqlDbType.VarChar).Value =  uName;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = pass;
            command2.Parameters.Add("@username", SqlDbType.VarChar).Value =  uName;
            command2.Parameters.Add("@password", SqlDbType.VarChar).Value = pass;
            returnValue = (string)command.ExecuteScalar();

            connection.Close();

            if (String.IsNullOrEmpty(returnValue))
            {
                return 0;
            }
            returnValue = returnValue.Trim();
            if (returnValue == "Администратор")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
