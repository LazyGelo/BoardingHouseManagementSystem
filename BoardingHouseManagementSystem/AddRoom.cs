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
    public partial class AddRoom : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRM_Click(object sender, EventArgs e)
        {
            //DateTime startdate = dtStart.Value;
            //DateTime judith = dtDue.Value;

            try
            {
                connection.Open();
                command = new MySqlCommand("INSERT INTO `room`(`ROOM_NUMBER`, `DESCRIPTION`, `MONTHLY_RENT`, `DATE_START`,`FULLNAME`) VALUES ('" + tbRNum.Text + "','" + tbDesc.Text + "','" + tbMonthlyy.Text + "','" + tbStartt.Text + "', '" + tbTntFname.Text + "' )", connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Room Info Updated");
                    // AdminPage adminp = new AdminPage();
                    //adminp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

