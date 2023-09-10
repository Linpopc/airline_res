using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace airline_reservation_system
{

    public partial class AddResScreen : Form
    {

        public AddResScreen()
        {
            InitializeComponent();
            loadDataGrid();

        }



        private void loadDataGrid()
        {
            try
            {
                FunctionsClass functions = new FunctionsClass();
                SqlConnection con = new SqlConnection(functions.connectionString);
                con.Open();


                SqlCommand cmd = new SqlCommand("Select * from FLIGHT", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                viewGrid.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {


                    string d_city = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string a_city = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    string d_t = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    string a_t = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    string d_d = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    string a_d = ds.Tables[0].Rows[i].ItemArray[6].ToString();




                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);

                    dataPush.Cells[0].Value = d_city;
                    dataPush.Cells[1].Value = a_city;
                    dataPush.Cells[2].Value = d_t;
                    dataPush.Cells[4].Value = a_t;
                    dataPush.Cells[3].Value = d_d;
                    dataPush.Cells[5].Value = a_d;
                    viewGrid.Rows.Add(dataPush);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                new PopupMessage("Ошибка" + ex).ShowDialog();
            }
        }



        private void searchRes_Click(object sender, EventArgs e)
        {

            if (dep_city.Text != "" && arr_city.Text!="" && !checkDate.Checked)
            {
                string dep = dep_city.Text;
                string arr = arr_city.Text;
                string data_arr = date_arr.Value.ToShortDateString();
                string data_dep = date_dep.Value.ToShortDateString();

                FunctionsClass functions = new FunctionsClass();


                try
                {
                    SqlConnection con = new SqlConnection(functions.connectionString);
                    con.Open();
                    SqlCommand command = new SqlCommand("Select * FROM Flight WHERE Departure_City = @department AND Arrival_City = @arrival AND Departure_Date = @d_d AND  Arrival_Date = @d_a", con);
                    command.Parameters.AddWithValue("@department", dep);
                    command.Parameters.AddWithValue("@d_d", data_dep);
                    command.Parameters.AddWithValue("@d_a", data_arr);
                    command.Parameters.AddWithValue("@arrival", arr);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);


                    viewGrid.Rows.Clear();
                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {


                        string d_city = dataset.Tables[0].Rows[i].ItemArray[3].ToString();
                        string a_city = dataset.Tables[0].Rows[i].ItemArray[4].ToString();
                        string d_t = dataset.Tables[0].Rows[i].ItemArray[7].ToString();
                        string a_t = dataset.Tables[0].Rows[i].ItemArray[8].ToString();
                        string d_d = dataset.Tables[0].Rows[i].ItemArray[5].ToString();
                        string a_d = dataset.Tables[0].Rows[i].ItemArray[6].ToString();




                        DataGridViewRow dataPush = new DataGridViewRow();
                        dataPush.CreateCells(viewGrid);

                        dataPush.Cells[0].Value = d_city;
                        dataPush.Cells[1].Value = a_city;
                        dataPush.Cells[2].Value = d_t;
                        dataPush.Cells[4].Value = a_t;
                        dataPush.Cells[3].Value = d_d;
                        dataPush.Cells[5].Value = a_d;
                        viewGrid.Rows.Add(dataPush);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    new PopupMessage("Неуспешный поиск!" + ex).ShowDialog();
                }
                finally
                {
                    dep_city.Text="";
                    arr_city.Text="";
                }
            }
            else if (dep_city.Text != "" && arr_city.Text!="" && checkDate.Checked)
            {
                string dep = dep_city.Text;
                string arr = arr_city.Text;
                FunctionsClass functions = new FunctionsClass();
                try
                {

                    SqlConnection con = new SqlConnection(functions.connectionString);
                    con.Open();
                    SqlCommand command = new SqlCommand("Select * FROM Flight WHERE Departure_City = @department AND Arrival_City = @arrival", con);
                    command.Parameters.AddWithValue("@department", dep);
                    command.Parameters.AddWithValue("@arrival", arr);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);


                    viewGrid.Rows.Clear();
                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {


                        string d_city = dataset.Tables[0].Rows[i].ItemArray[3].ToString();
                        string a_city = dataset.Tables[0].Rows[i].ItemArray[4].ToString();
                        string d_t = dataset.Tables[0].Rows[i].ItemArray[7].ToString();
                        string a_t = dataset.Tables[0].Rows[i].ItemArray[8].ToString();
                        string d_d = dataset.Tables[0].Rows[i].ItemArray[5].ToString();
                        string a_d = dataset.Tables[0].Rows[i].ItemArray[6].ToString();




                        DataGridViewRow dataPush = new DataGridViewRow();
                        dataPush.CreateCells(viewGrid);

                        dataPush.Cells[0].Value = d_city;
                        dataPush.Cells[1].Value = a_city;
                        dataPush.Cells[2].Value = d_t;
                        dataPush.Cells[4].Value = a_t;
                        dataPush.Cells[3].Value = d_d;
                        dataPush.Cells[5].Value = a_d;
                        viewGrid.Rows.Add(dataPush);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    new PopupMessage("Неуспешный поиск!" + ex).ShowDialog();
                }
                finally
                {
                    dep_city.Text="";
                    arr_city.Text="";
                }
            }
            else
            {
                new PopupMessage("Введите все данные!").ShowDialog();
            }
        }

        private void viewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int FlightID;
        private void submitButton_Click(object sender, EventArgs e)
        {
            FunctionsClass functions = new FunctionsClass();
            if (viewGrid.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = viewGrid.SelectedRows[0];
                string departure = selectedRow.Cells["place_department"].Value.ToString();
                string arrive = selectedRow.Cells["place_arrive"].Value.ToString();
                string d_d = selectedRow.Cells["date_department"].Value.ToString();
                string d_a = selectedRow.Cells["date_arrive"].Value.ToString();
                string t_d = selectedRow.Cells["time_depart"].Value.ToString();
                string t_a = selectedRow.Cells["time_arrive"].Value.ToString();
                DialogResult confirmationResult = MessageBox.Show("Вы точно хотите забронировать этот рейс?\n" + departure + " - " + arrive + "\n(Отправление: " + d_d +" "+ t_d +"\nПрибытие: "+d_a+" "+t_a+")", "Подверждение бронирования", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationResult == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(functions.connectionString);
                    SqlCommand command2 = new SqlCommand("SELECT Flight_ID FROM Flight WHERE Departure_City = @dep And Arrival_City = @arr And Departure_Time = @d_t And Arrival_Time = @a_t", connection);
                    connection.Open();

                    command2.Parameters.AddWithValue("@dep", departure);
                    command2.Parameters.AddWithValue("@d_t", t_d);
                    command2.Parameters.AddWithValue("@a_t", t_a);
                    command2.Parameters.AddWithValue("@arr", arrive);
                    FlightID = (int)command2.ExecuteScalar();

                    connection.Close();
                    new ConfirmBooking().Show();
                    this.Hide();


                }

            }
            else
            {
                MessageBox.Show("Пожалуйста выберите рейс.");
            }
        }
    }
}