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
    public partial class ADMNPaymentt : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static ADMNPaymentt _instance;
        public static ADMNPaymentt Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ADMNPaymentt();
                return _instance;
            }
        }
        public ADMNPaymentt()
        {
            InitializeComponent();
            loadData();
        }

        private void btnPaymnt_Click(object sender, EventArgs e)
        {
            UpdatePayment updpayment = new UpdatePayment();
            updpayment.Show();
            //MessageBox.Show("Login Successful!");
            this.Hide();
        }
        void loadData()
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `OR_NUMBER`,`PAYMENT_AMOUNT`, `PAYMENT_DATE`,`PAYMENT_STATUS`, `FULLNAME`  FROM `payment`", connection);
                adapter.Fill(dt);
                gvPayments.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

