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
    public partial class AdminPage : Form
    {
        public static AdminPage instance;
        public AdminPage()
        {
            InitializeComponent();
            instance = this;

        }

        
         private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void ADMNDb_Click(object sender, EventArgs e)
        {
            if (!panelName.Controls.Contains(ADMNDash.Instance))
            {
                panelName.Controls.Add(ADMNDash.Instance);
                ADMNDash.Instance.Dock = DockStyle.Fill;
                ADMNDash.Instance.BringToFront();
            }
            else
            {
                ADMNDash.Instance.BringToFront();
            }
        }

        private void ADMNTp_Click(object sender, EventArgs e)
        {
            if (!panelName.Controls.Contains(ADMNTNTp.Instance))
            {
                panelName.Controls.Add(ADMNTNTp.Instance);
                ADMNTNTp.Instance.Dock = DockStyle.Fill;
                ADMNTNTp.Instance.BringToFront();
            }
            else
            {
                ADMNTNTp.Instance.BringToFront();
            }
        }
    

        private void ADMNRoom_Click(object sender, EventArgs e)
        {
        if (!panelName.Controls.Contains(ADMNRoomm.Instance))
        {
            panelName.Controls.Add(ADMNRoomm.Instance);
            ADMNRoomm.Instance.Dock = DockStyle.Fill;
            ADMNRoomm.Instance.BringToFront();
        }
        else
        {
                ADMNRoomm.Instance.BringToFront();
        }
    }


        private void ADMNPayment_Click(object sender, EventArgs e)
        {
            if (!panelName.Controls.Contains(ADMNPaymentt.Instance))
            {
                panelName.Controls.Add(ADMNPaymentt.Instance);
                ADMNPaymentt.Instance.Dock = DockStyle.Fill;
                ADMNPaymentt.Instance.BringToFront();
            }
            else
            {
                ADMNPaymentt.Instance.BringToFront();
            }
        }

        private void ADMNNotice_Click(object sender, EventArgs e)
        {
        if (!panelName.Controls.Contains(ADMNNoticee.Instance))
            {
                panelName.Controls.Add(ADMNNoticee.Instance);
                ADMNNoticee.Instance.Dock = DockStyle.Fill;
                ADMNNoticee.Instance.BringToFront();
            }
            else
            {
                ADMNNoticee.Instance.BringToFront();
            }
        }

        private void ADMNSugg_Click(object sender, EventArgs e)
        {
            if (!panelName.Controls.Contains(ADMNSuggest.Instance))
            {
                panelName.Controls.Add(ADMNSuggest.Instance);
                ADMNSuggest.Instance.Dock = DockStyle.Fill;
                ADMNSuggest.Instance.BringToFront();
            }
            else
            {
                ADMNSuggest.Instance.BringToFront();
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
