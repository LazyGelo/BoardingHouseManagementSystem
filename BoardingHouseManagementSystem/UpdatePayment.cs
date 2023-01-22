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
   
    public partial class UpdatePayment : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        MySqlDataReader mdr;
        public UpdatePayment()
        {
            InitializeComponent();
            status2();
        }
        void status2()
        {
            cbUpdStatus2.Items.Add("Pending");
            cbUpdStatus2.Items.Add("Received");
        }

        private void btnUpdatePymnt_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("UPDATE `payment` SET `PAYMENT_STATUS` = '" +cbUpdStatus2.Text + "'  WHERE `OR_NUMBER` = '" + tbUpdOrNum.Text + "' ", connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Payment Updated");
                    // AdminPage adminp = new AdminPage();
                    //adminp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to Update Payment");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}



