using airline_reservation_system;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class AddNewFlight : Form
    {

        public AddNewFlight()
        {
            InitializeComponent();
            loadAirplanes();
            loadCities();
        }

        public void loadAirplanes()
        {
            try
            {
                FunctionsClass functions = new FunctionsClass();
                SqlConnection con = new SqlConnection(functions.connectionString);
                con.Open();

                this.airplaneIDBox.Items.Clear();
                SqlCommand cmd = new SqlCommand("Select Airplane_ID from airplane", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    this.airplaneIDBox.Items.Add(id);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                new PopupMessage("Ошибка!" + ex).ShowDialog();
            }
        }


        public void loadCities()
        {
            try
            {
                FunctionsClass functions = new FunctionsClass();
                SqlConnection con = new SqlConnection(functions.connectionString);
                con.Open();

                this.fromCity.Items.Clear();
                this.toCity.Items.Clear();
                SqlCommand cmd = new SqlCommand("Select City from airport", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string city = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    this.fromCity.Items.Add(city);
                    this.toCity.Items.Add(city);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                new PopupMessage("Ошибка!" + ex).ShowDialog();
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionsClass functions = new FunctionsClass();
                SqlConnection con = new SqlConnection(functions.connectionString);
                string A_ID = airplaneIDBox.Text;
                string F_ID = flightID.Text;
                string F_CD = fromCity.Text;
                string F_CA = toCity.Text;
                string DD = dateD.Text;
                string AD = dateA.Text;

                string arrivalTime = AH.Text+":"+AM.Text+":00";
                string departureTime = DH.Text + ":" +DM.Text+ ":00";

                con.Open();
                string firstQuery = "INSERT INTO FLIGHT(Flight_ID, Airplane_ID, Departure_City,Arrival_City, Departure_Time, Arrival_Time, Departure_Date, Arrival_Date) values(@fi, @ai, @CF, @CT, @DT, @AT, @DD, @AD)";
                SqlCommand cmd = new SqlCommand(firstQuery, con);
                cmd.Parameters.AddWithValue("@fi", F_ID);
                cmd.Parameters.AddWithValue("@ai", A_ID);
                cmd.Parameters.AddWithValue("@CF", F_CD);
                cmd.Parameters.AddWithValue("@CT", F_CA);
                cmd.Parameters.AddWithValue("@AD", DD);
                cmd.Parameters.AddWithValue("@DD", AD);
                cmd.Parameters.AddWithValue("@AT", arrivalTime);
                cmd.Parameters.AddWithValue("@DT", departureTime);
                cmd.ExecuteNonQuery();
                con.Close();
                this.msgBox.Text = "Ваши данные успешно сохарнены😊";
            }
            catch (Exception ex)
            {
                new PopupMessage("Ошибка!" + ex).ShowDialog();
            }
            finally
            {
                airplaneIDBox.Text = "";
                flightID.Text = "";
                fromCity.Text = "";
                toCity.Text = "";
                dateD.Text = "";
                dateA.Text = "";
            }

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
    }
}
