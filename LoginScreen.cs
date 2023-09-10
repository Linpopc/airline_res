using AirlineReservationSystem;
using System;
using System.Windows.Forms;

namespace airline_reservation_system
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "" || password == "")
            {
                new PopupMessage("Введите учетные данные!").ShowDialog();
                txtPassword.Text = "";
            }
            else
            {
                try
                {
                    FunctionsClass functions = new FunctionsClass();

                    if (functions.validateLogin(username, password) == 0)
                    {
                        new PopupMessage("Неправильные учетные данные!").ShowDialog();
                    }
                    else if (functions.validateLogin(username, password) == 1)
                    {
                        new Dashboard().Show();
                        new PopupMessage("Вход успешен!").ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        new UserMenuScreen().Show();
                        new PopupMessage("Вход успешен!").ShowDialog();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    new PopupMessage("Ошибка входа!" + ex).ShowDialog();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNewUsr_Click(object sender, EventArgs e)
        {
            new NewUserScreen().Show();
            this.Hide();
        }
    }
}
