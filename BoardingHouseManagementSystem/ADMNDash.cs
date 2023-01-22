using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardingHouseManagementSystem
{
    public partial class ADMNDash : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static ADMNDash _instance;
        public static ADMNDash Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ADMNDash();
                return _instance;
            }
        }
        public ADMNDash()
        {
            InitializeComponent();
            gettenants();
            getrooms();
            getearnings();
        }
        void gettenants()
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("SELECT COUNT(*) from tenant ", connection);
                int tenants = Convert.ToInt32(command.ExecuteScalar());
                lbTnt.Text = tenants.ToString();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void getrooms()
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("SELECT COUNT(*) from room ", connection);
                int rooms = Convert.ToInt32(command.ExecuteScalar());
                lbRooms.Text = rooms.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void getearnings()
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("SELECT SUM(PAYMENT_AMOUNT) from `payment` ", connection);
                int payment = Convert.ToInt32(command.ExecuteScalar());
                labelEarnings.Text = payment.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
}

