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
    public partial class ADMNTNTp : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static ADMNTNTp _instance;
        public static ADMNTNTp Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ADMNTNTp();
                return _instance;
            }
        }
        public ADMNTNTp()
        {

            InitializeComponent();
            loadData();
        }

        private void addTnt_Click(object sender, EventArgs e)
        {
            AddTenant addtenant = new AddTenant();
            this.Hide();
            addtenant.Show();
            //MessageBox.Show("Login Successful!");
          
        }
        void loadData()
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `FULLNAME`, `ADDRESS`, `EMAIL`, `TNT_PASSWORD`, `PHONE`, `GENDER` FROM `tenant`", connection);
                adapter.Fill(dt);
                gvTenant.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void btnUpdProfile_Click(object sender, EventArgs e)
        {
            UpdateTntP updtntp = new UpdateTntP();
          updtntp.Show();
            //MessageBox.Show("Login Successful!");
            this.Hide();
        }
    }
    }


