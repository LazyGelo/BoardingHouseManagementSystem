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
    public partial class TNTPaymentt : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static TNTPaymentt _instance;
        public static TNTPaymentt Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TNTPaymentt();
                return _instance;
            }
        }
        public TNTPaymentt()
        {
            InitializeComponent();
            loadData();
        }

      
        void loadData()
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `OR_NUMBER`,`PAYMENT_AMOUNT`,`PAYMENT_DATE`,`PAYMENT_STATUS` FROM `payment`", connection);
                adapter.Fill(dt);
                gvPayment2.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchOr_Click(object sender, EventArgs e)
        {
            connection.Close();


            try
            {

                MySqlDataAdapter adapter;
                DataTable table;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT *FROM payment WHERE or_number = '" + tbSearchOrNum.Text + "' ", connection);
                table = new DataTable();
                adapter.Fill(table);
                gvPayment2.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPayRent_Click(object sender, EventArgs e)
        {
           SendPayment sendpayment = new SendPayment();
           sendpayment.Show();
            //MessageBox.Show("Login Successful!");
            this.Hide();
        }
    }

 }



