using airline_reservation_system;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class AddNewAirlineComp : Form
    {



        public AddNewAirlineComp()
        {
            InitializeComponent();
            this.msgBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        public void save()
        {
            string A_ID = airlineID.Text;
            string A_Name = airlineName.Text;
            string A_Crafts = crafts.Text;
            if (A_Crafts != "" &&  A_Name != "" && A_ID != "")
            {
                try
                {
                    FunctionsClass functions = new FunctionsClass();
                    SqlConnection con = new SqlConnection(functions.connectionString);


                    con.Open();
                    string firstQuery = "INSERT INTO AIRLINE(Airline_ID, Airline_Name, Airplanes) values(@id, @name, @crft)";
                    SqlCommand cmd = new SqlCommand(firstQuery, con);
                    cmd.Parameters.AddWithValue("@name", A_Name);
                    cmd.Parameters.AddWithValue("@id", A_ID);
                    cmd.Parameters.AddWithValue("@crft", A_Crafts);
                    cmd.ExecuteNonQuery();
                    this.msgBox.Text = "Ваши данные успешно сохранены😊";
                    con.Close();
                }
                catch (Exception ex)
                {
                    new PopupMessage("Ошибка!" + ex).ShowDialog();
                }
                finally
                {
                    airlineID.Text = "";
                    airlineName.Text = "";
                    crafts.Text = "";
                }
            }
            else new PopupMessage("Введите все данные!").ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        public void backToHome()
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void airlineID_Click(object sender, EventArgs e)
        {
            this.msgBox.Text = "";
        }
    }
}
