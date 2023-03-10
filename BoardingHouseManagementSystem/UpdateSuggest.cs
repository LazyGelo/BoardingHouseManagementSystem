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
    public partial class UpdateSuggest : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        MySqlDataReader mdr;
        public UpdateSuggest()
        {
            InitializeComponent();
            status3();
        }
        void status3()
        {
            cbUpdStatus3.Items.Add("Pending");
            cbUpdStatus3.Items.Add("Working");
            cbUpdStatus3.Items.Add("Finished");
        }

        private void btnUpdateSuggest_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("UPDATE `suggestion` SET `SUGG_STATUS` = '" + cbUpdStatus3.Text + "'  WHERE `SUGG_NUM` = '" + tbUpdSuggNum.Text + "' ", connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Suggestion Updated");
                    // AdminPage adminp = new AdminPage();
                    //adminp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to Update Suggestion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
        
