using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace airline_reservation_system
{
    public partial class NewUserScreen : Form
    {
        public NewUserScreen()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {


            string uname = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string mail = textBoxMail.Text;
            string name = textBox1.Text;
            if (!int.TryParse(textBox3.Text, out int tele))
            { new PopupMessage("Неверный формат телефона").ShowDialog(); return; }
            if (!int.TryParse(textBox2.Text, out int pnum))
            { new PopupMessage("Неверный формат паспорта").ShowDialog(); return; }


            if (uname != "" && password != "" && mail !="" && name !="" && tele >0 && pnum > 0)
            {
                FunctionsClass functions = new FunctionsClass();

                if (functions.checkUserTaken(uname) == 0)
                {
                    new PopupMessage("Извините, имя пользователя занято!").ShowDialog();
                }
                else if (functions.checkMailTaken(mail) == 0)
                {
                    new PopupMessage("Извините, данная почта зарегистрирована!").ShowDialog();
                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(functions.connectionString);
                        string query = "INSERT INTO Пользователи (Логин, Пароль, Почта, Паспорт, ФИО, Телефон) VALUES ('" + uname + "','" + password + "','" + mail + "', '" + pnum + "' ,'" + name + "' ,'" + tele + "')";
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        new PopupMessage("Аккаунт зарегестрирован успешно! Пожалуйста, используйте пароль и имя пользователя для авторизации..").ShowDialog();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        new PopupMessage("Ошибка регистрации аккаунта!" + ex).ShowDialog();
                    }
                    finally
                    {
                        textBoxMail.Text = "";
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                    }
                }
            }
            else
            {
                new PopupMessage("Введите учетные данные!").ShowDialog();
            }
        }

        private void txtBckToLog_Click(object sender, EventArgs e)
        {
            new LoginScreen().Show();
            this.Hide();
        }
    }
}
