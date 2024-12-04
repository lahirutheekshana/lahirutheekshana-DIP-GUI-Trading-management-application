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

namespace TradingManagementApp
{
    public partial class frmLogin : Form
    {
        String email = "";

        public frmLogin()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        MySqlConnection con = DbConnection.connectDB();

        private void clearData()
        {
            txtMail.Text = String.Empty;
            txtPass.Text = String.Empty;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackSignup_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String login = "SELECT user_email FROM users WHERE user_email = '"+txtMail.Text+"' and user_password = '"+txtPass.Text+"'";
                MySqlCommand cmd = new MySqlCommand(login, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    email = txtMail.Text;
                    new FrmDashboard(email).Show();
                    this.Hide();
                    con.Close();

                }

                else
                {
                    MessageBox.Show("Invalid Email or Password");
                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnClear1_Click(object sender, EventArgs e)
        {
            this.clearData();
        }

        private void ShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheck.Checked)
            {
                txtPass.PasswordChar = '\0';          
            }
            else
            {
                txtPass.PasswordChar = '*';

            }
        }
    }
}
