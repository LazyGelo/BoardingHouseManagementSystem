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
    public partial class SendPayment : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        public SendPayment()
        {
            InitializeComponent();
        }

        private void btnSendPymnt_Click(object sender, EventArgs e)
        {
            var status = "Pending";
           try
            {
                connection.Open();
                command = new MySqlCommand("INSERT INTO `payment`(`OR_NUMBER`, `PAYMENT_AMOUNT`, `PAYMENT_DATE`, `PAYMENT_STATUS`,`FULLNAME`) VALUES ('" + tbOrNumz.Text + "','" + tbAmntPay.Text + "','" + tbPymntDatez.Text + "','" +status+ "', '" + tbPymntFnamez.Text + "' )", connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Payment Info Sent");
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
