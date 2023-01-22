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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=boarding_house_management_system; username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoginA_Click(object sender, EventArgs e)
        {
            loginform.Email = tbEmail.Text;
            loginform.Pass = tbPass.Text;
            
            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPass.Text))
            {

                MessageBox.Show("Input Email and Password", "Error");
            }
            else
            {

               
                connection.Open();
                string selectQuery = "SELECT * FROM login WHERE log_email = '" + loginform.Email + "' AND log_password = '" + loginform.Pass + "';";
              
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {

                    AdminPage adminqt = new AdminPage();
                    adminqt.Show();
                    MessageBox.Show("Login Successful!");
                    this.Hide();}
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.");
                }
                    mdr.Close();
                    connection.Close();
                }
            }

        private void btnLoginT_Click(object sender, EventArgs e)
        {

            loginform.Email = tbEmail.Text;
            loginform.Pass = tbPass.Text;

            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPass.Text))
            {

                MessageBox.Show("Input Email and Password", "Error");
            }
            else
            {


                connection.Open();
                string selectQuery = "SELECT * FROM tenant WHERE EMAIL = '" + loginform.Email + "' AND TNT_PASSWORD = '" + loginform.Pass + "';";

                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    TenantPage tenantqt = new TenantPage();
                    tenantqt.Show();
                    MessageBox.Show("Welcome Tenant!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.");
                }
                    mdr.Close();
                    connection.Close();
                }
            }
        }
    }

  
    

