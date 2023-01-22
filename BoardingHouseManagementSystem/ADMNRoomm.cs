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
    public partial class ADMNRoomm : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static ADMNRoomm _instance;
        public static ADMNRoomm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ADMNRoomm();
                return _instance;
            }
        }
        public ADMNRoomm()
        {
            InitializeComponent();
            loadData();
        }

        
            private void addRoom_Click(object sender, EventArgs e)
            {
                AddRoom addroomm = new AddRoom();
                addroomm.Show();
                //MessageBox.Show("Login Successful!");
                this.Hide();
            }
            void loadData()
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `ROOM_NUMBER`, `DESCRIPTION`, `MONTHLY_RENT`, `DATE_START`, `FULLNAME` FROM `room`", connection);
                    adapter.Fill(dt);
                    gvRoomm.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

    
        
    }
    }

