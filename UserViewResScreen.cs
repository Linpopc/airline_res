using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline_reservation_system
{
    public partial class UserViewResScreen : Form
    {
        public UserViewResScreen()
        {
            InitializeComponent();
        }
        private void searchButton_Click_1(object sender, EventArgs e)
        {
            if (textBoxPassport.Text != "")
            {
                if (!int.TryParse(textBoxPassport.Text, out int pNumber))
                { new PopupMessage("Неверный формат").ShowDialog(); return; }

                FunctionsClass functions = new FunctionsClass();

                try
                {
                   
                }
                catch (Exception ex)
                {
                    new PopupMessage("Неуспешный поиск!" + ex).ShowDialog();
                }
                finally
                {
                    textBoxPassport.Text = "";
                }
            }
            else
            {
                new PopupMessage("Введите паспортные данные!").ShowDialog();
            }
        }

        
    }
}
