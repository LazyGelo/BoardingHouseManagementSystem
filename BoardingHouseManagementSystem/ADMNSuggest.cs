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
    public partial class ADMNSuggest : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        private static ADMNSuggest _instance;
        public static ADMNSuggest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ADMNSuggest();
                return _instance;
            }
        }
        public ADMNSuggest()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `SUGGESTION`, `DATE_SUGGESTION`, `SUGG_NUM`, `SUGG_STAT`, `FULLNAME` FROM `suggestion`", connection);
                adapter.Fill(dt);
                gvSuggestion.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdSugg_Click(object sender, EventArgs e)
        {
           UpdateSuggest updsugg = new UpdateSuggest();
           updsugg.Show();
            //MessageBox.Show("Login Successful!");
            this.Hide();
        }
    }

}
