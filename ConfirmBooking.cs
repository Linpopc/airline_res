using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace airline_reservation_system
{
    public partial class ConfirmBooking : Form
    {

        public ConfirmBooking()
        {
            InitializeComponent();
        }

        private void checkBoxClassA_Clicked(object sender, EventArgs e)
        {
            checkBoxClassB.CheckState = CheckState.Unchecked;
            checkBoxClassC.CheckState = CheckState.Unchecked;
        }

        private void checkBoxClassB_Clicked(object sender, EventArgs e)
        {
            checkBoxClassA.CheckState = CheckState.Unchecked;
            checkBoxClassC.CheckState = CheckState.Unchecked;
        }

        private void checkBoxClassC_Clicked(object sender, EventArgs e)
        {
            checkBoxClassA.CheckState = CheckState.Unchecked;
            checkBoxClassB.CheckState = CheckState.Unchecked;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (seatNumber.Text !=""  && (checkBoxClassA.CheckState==CheckState.Checked || checkBoxClassB.CheckState == CheckState.Checked || checkBoxClassC.CheckState == CheckState.Checked))
            {

                string tClass = "";

                string sNumber = seatNumber.Text;
                if (checkBoxClassA.Checked)
                {
                    tClass = "A";
                }
                else if (checkBoxClassB.Checked)
                {
                    tClass = "B";
                }
                else if (checkBoxClassC.Checked)
                {
                    tClass = "C";
                }

                FunctionsClass functions = new FunctionsClass();
                AddResScreen func = new AddResScreen();
                if (functions.checkSeatTaken(func.FlightID, sNumber) == 0)
                {
                    new PopupMessage("Извините, данное место занято!").ShowDialog();
                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(functions.connectionString);
                        connection.Open();

                        string query = "INSERT INTO Билеты (Место_в_салоне, Идентификатор_маршрута, Класс_билета) values (@seats, @flightID, @class)";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@seats", sNumber);
                        cmd.Parameters.AddWithValue("@flightID", func.FlightID);
                        cmd.Parameters.AddWithValue("@class", tClass);


                        cmd.ExecuteNonQuery();
                        int ticketID;

                        string query2 = "SELECT MAX(Идентификатор_билета) FROM Билеты";
                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            using (SqlDataReader reader = command2.ExecuteReader())
                            {
                                reader.Read();
                                ticketID = reader.GetInt32(0);
                                reader.Close();
                            }
                        }
                        connection.Close();
                        this.Close();
                        new PopupMessage("Бронирование успешно, ваш идентификационный номер: " + ticketID).ShowDialog();


                    }
                    catch (Exception ex)
                    {
                        new PopupMessage("Ошибка бронирования!" + ex).ShowDialog();
                    }
                    finally
                    {
                        checkBoxClassA.CheckState = CheckState.Unchecked;
                        checkBoxClassB.CheckState = CheckState.Unchecked;
                        checkBoxClassC.CheckState = CheckState.Unchecked;
                        seatNumber.Text = "";

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