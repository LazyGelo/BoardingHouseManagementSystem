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
    public partial class AddTenant : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        
        public AddTenant()
        {
            InitializeComponent();
            gender();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void gender()
        {
            cbGender.Items.Add("MALE");
            cbGender.Items.Add("FEMALE");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var role = "Tenant";
            try
            {
                connection.Open();
                command = new MySqlCommand("INSERT INTO `tenant`(`FULLNAME`, `ADDRESS`, `EMAIL`, `TNT_PASSWORD`, `PHONE`, `GENDER`,`ROLE` ) VALUES ('" + tbName.Text + "','" + tbAdd.Text + "','" + tbMail.Text + "','" + tbPasswordd.Text + "','" + tbPNum.Text + "','" + cbGender.Text + "', '"+role+"' )",connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr>0)
                {
                    MessageBox.Show("Tenant Successfully Added!");
                    this.Hide();
                    AdminPage adminp = new AdminPage();
                    adminp.Show();
                    
                }
                else
                {
                    MessageBox.Show("Failed to Add Tenant :(");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
