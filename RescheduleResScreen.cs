using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace airline_reservation_system
{
    public partial class RescheduleResScreen : Form
    {
        public RescheduleResScreen()
        {
            InitializeComponent();
        }


        private void validateButton_Click(object sender, EventArgs e)
        {
            if (textBoxRID.Text != "")
            {
                if (!int.TryParse(textBoxRID.Text, out int reservationID))
                { new PopupMessage("Неверный формат").ShowDialog(); return; }
                int reservationNum = 0;
                FunctionsClass functions = new FunctionsClass();

                try
                {
                    SqlConnection connection = new SqlConnection(functions.connectionString);
                    connection.Open();
                    string query1 = @"SELECT ReservationID FROM ReservationTable WHERE ReservationID LIKE '" + reservationID + "'";
                    try
                    {
                        using (SqlCommand command1 = new SqlCommand(query1, connection))
                        {
                            using (SqlDataReader reader = command1.ExecuteReader())
                            {
                                reader.Read();
                                reservationNum = reader.GetInt32(0);
                                reader.Close();
                            }
                        }
                        if (reservationNum != 0)
                        {
                            new PopupMessage("Бронировние существует!").ShowDialog();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        new PopupMessage("Данного ID не существует!").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    new PopupMessage("Ошибка подтверждения!" + ex).ShowDialog();
                }
            }
            else
            {
                new PopupMessage("Введите ID!").ShowDialog();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxRID.Text, out int reservationID))
            { new PopupMessage("Неверный формат").ShowDialog(); return; }
            string sNumber = seatNumber.Text;
            string date = datePicker.Value.ToShortDateString();

            FunctionsClass functions = new FunctionsClass();

            if (textBoxRID.Text != "" && seatNumber.Text != "")
            {
                if (functions.checkSeatTaken(date, sNumber) == 0)
                {
                    new PopupMessage("Извинините, на эту дату место занято!").ShowDialog();
                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(functions.connectionString);
                        string query2 = @"UPDATE ReservationTable SET Date = '" + date + "', SeatNumber= '" + sNumber + "' WHERE ReservationID = '" + reservationID + "'";
                        SqlCommand command = new SqlCommand(query2, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        new PopupMessage("Успешное изменение бронирования!").ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        new PopupMessage("Ошибка изменения брони!" + ex).ShowDialog();
                    }
                }
            }
            else
            {
                new PopupMessage("Введите все данные!").ShowDialog();
            }
        }
    }
}
