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
    
    public partial class UpdateTntP : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        MySqlDataReader mdr;
        public UpdateTntP()
        {
            InitializeComponent();
        }

        private void btnUpdateTnt_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("UPDATE `tenant` SET `FULLNAME` = '" + tbUpdName.Text + "', `ADDRESS` = '"+tbUpdAdd.Text+"',`EMAIL` = '"+tbUpdMail.Text+"',`TNT_PASSWORD` = '"+tbUpdPasswordd.Text+"', `PHONE` = '"+tbUpdPNum.Text+"' WHERE `TENANT_ID` = '" + tbTntId2.Text + "' ", connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Tenant Updated");
                    // AdminPage adminp = new AdminPage();
                    //adminp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to Update Tenant");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}



