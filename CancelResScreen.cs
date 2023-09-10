using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace airline_reservation_system
{
    public partial class CancelResScreen : Form
    {
        public CancelResScreen()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.CheckState == CheckState.Unchecked)
            {
                new PopupMessage("Пожалуйста, примите соглашение о необратимости процесса!").ShowDialog();
            }
            else
            {
                if(textBoxRID.Text != "" && textBoxPassport.Text != "")
                {
                    
                    if (!int.TryParse(textBoxPassport.Text, out int passportId) || !int.TryParse(textBoxRID.Text, out int reservationId))
                    { new PopupMessage("Неверный формат").ShowDialog(); return; }

                    FunctionsClass functions = new FunctionsClass();

                    try
                    {
                        SqlConnection connection = new SqlConnection(functions.connectionString);
                        string query = @"DELETE FROM ReservationTable WHERE (ReservationID= '" + reservationId + "' AND PassportID= '" + passportId + "')";
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        new PopupMessage("Успешная отмена бронирования!").ShowDialog();
                        connection.Close();
                    }
                    catch(Exception ex)
                    {
                        new PopupMessage("Бронирование не найдено!" + ex).ShowDialog();
                    }
                    finally
                    {
                        textBoxRID.Text = "";
                        textBoxPassport.Text = "";
                        checkBoxAgree.CheckState = CheckState.Unchecked;
                    }
                }
                else
                {
                    new PopupMessage("Введите все данные!").ShowDialog();
                }
            }
        }
    }
}
