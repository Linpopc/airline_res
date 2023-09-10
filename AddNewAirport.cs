using airline_reservation_system;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class AddNewAirport : Form
    {

        public AddNewAirport()
        {
            InitializeComponent();
        }



        private void deleteButtonCon_Click(object sender, EventArgs e)
        {
            string A_ID = airportID.Text;
            string A_Name = airportName.Text;
            string A_City = city.Text;
            string A_Country = country.Text;
            if (A_ID != "" && A_Name != "" && A_City!="" && A_Country!="")
            {
                try
                {
                    FunctionsClass functions = new FunctionsClass();
                    SqlConnection con = new SqlConnection(functions.connectionString);


                    con.Open();
                    string firstQuery = "INSERT INTO AIRPORT(Airport_ID, Airport_Name, City, Country) values(@id, @name, @city, @country)";
                    SqlCommand cmd = new SqlCommand(firstQuery, con);
                    cmd.Parameters.AddWithValue("@name", A_Name);
                    cmd.Parameters.AddWithValue("@id", A_ID);
                    cmd.Parameters.AddWithValue("@city", A_City);
                    cmd.Parameters.AddWithValue("@country", A_Country);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ваши данные успешно сохранены😊");
                    con.Close();
                }
                catch (Exception ex)
                {
                    new PopupMessage("Ошибка!" + ex).ShowDialog();
                }
                finally
                {
                    airportID.Text = "";
                    airportName.Text = "";
                    city.Text = "";
                    country.Text = "";
                }
            }
            else new PopupMessage("Введите все данные").ShowDialog();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
