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
    public partial class TNTSuggest : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static TNTSuggest _instance;
        public static TNTSuggest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TNTSuggest();
                return _instance;
            }
        }
        public TNTSuggest()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var suggstat = "Pending";
            try
            {
                connection.Open();
                command = new MySqlCommand("INSERT INTO `suggestion`(`FULLNAME`, `DATE_SUGGESTION`, `SUGGESTION`, `SUGG_STAT`,`SUGG_NUM`) VALUES ('" + tbTntId.Text + "','" + tbDateSugg.Text + "','" + tbSuggests.Text + "','"+suggstat+"','"+tbSuggNumz+"' )", connection);
                int ctr = command.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Suggestion Sent to the owner");
                    // AdminPage adminp = new AdminPage();
                    //adminp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Suggestion sent failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

