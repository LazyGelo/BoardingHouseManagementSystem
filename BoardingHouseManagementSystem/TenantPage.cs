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
    public partial class TenantPage : Form
    {
        public static TenantPage instance;
        public TenantPage()
        {
            InitializeComponent();
            instance = this;

        }

        private void TNTNotice_Click(object sender, EventArgs e)
        {
            if (!panelName2.Controls.Contains(TNTNoticee.Instance))
            {
                panelName2.Controls.Add(TNTNoticee.Instance);
                TNTNoticee.Instance.Dock = DockStyle.Fill;
                TNTNoticee.Instance.BringToFront();
            }
            else
            {
                TNTNoticee.Instance.BringToFront();
            }
        }
    

       


private void TNTSugg_Click(object sender, EventArgs e)
        {
            if (!panelName2.Controls.Contains(TNTSuggest.Instance))
            {
                panelName2.Controls.Add(TNTSuggest.Instance);
                TNTSuggest.Instance.Dock = DockStyle.Fill;
                TNTSuggest.Instance.BringToFront();
            }
            else
            {
                TNTSuggest.Instance.BringToFront();
            }
        }


        private void TNTPayment_Click(object sender, EventArgs e)
        {
            if (!panelName2.Controls.Contains(TNTPaymentt.Instance))
            {
                panelName2.Controls.Add(TNTPaymentt.Instance);
                TNTPaymentt.Instance.Dock = DockStyle.Fill;
                TNTPaymentt.Instance.BringToFront();
            }
            else
            {
                TNTPaymentt.Instance.BringToFront();
            }
        }


        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }
    }
}
