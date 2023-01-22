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
    public partial class ADMNNoticee : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static ADMNNoticee _instance;
        public static ADMNNoticee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ADMNNoticee();
                return _instance;
            }
        }
        public ADMNNoticee()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("INSERT INTO `notice`(`NOTICE`, `DATE_OF_NOTICE`, `FULLNAME`) VALUES ('" + tbMessage.Text + "','" + tbDateSent.Text + "', '"+ tbSendTo.Text + "' )", connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Notice Sent");
                    // AdminPage adminp = new AdminPage();
                    //adminp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to Send");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
