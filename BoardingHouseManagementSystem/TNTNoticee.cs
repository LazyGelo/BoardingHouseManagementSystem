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
    public partial class TNTNoticee : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static TNTNoticee _instance;
        public static TNTNoticee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TNTNoticee();
                return _instance;
            }
        }
        public TNTNoticee()
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT  notice, date_of_notice, fullname FROM `notice`", connection);
                adapter.Fill(dt);
                gvNoticee.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchId_Click(object sender, EventArgs e)
        {
            connection.Close();


            try
            {

                MySqlDataAdapter adapter;
                DataTable table;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT *FROM `notice` WHERE `FULLNAME` = '" + tbSearchId.Text + "' ", connection);
                table = new DataTable();
                adapter.Fill(table);
                gvNoticee.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
