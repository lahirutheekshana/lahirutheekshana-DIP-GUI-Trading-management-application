using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingManagementApp.UserControls
{
    public partial class UC_History : UserControl
    {
        MySqlConnection con = DbConnection.connectDB();

        public UC_History()
        {
            InitializeComponent();
        }

        private void UC_History_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            txtTradeID.Text = "";
            dateTimePicker1.Text = "2000/01/01";
        }

        private void populateGrid()
        {
            try
            {
                con.Open();
                String selectQuery = "SELECT * FROM trade WHERE T_Date = @date";
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);

                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DGVHistory.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void populateGrid1()
        {
            try
            {
                con.Open();
                String selectQuery = "SELECT * FROM trade WHERE T_id = @Tradeid";
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@Tradeid", txtTradeID.Text);

                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DGVHistory.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btnView3_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Text == "2000-01-01" || dateTimePicker1.Text == "")
            {
                if(txtTradeID.Text == "")
                {
                    MessageBox.Show("Please Check the Date Again");
                }
                else
                {
                    populateGrid1();
                }
                
            }
            else
            {
                if(txtTradeID.Text == "")
                {
                    populateGrid();
                }
                else
                {
                    MessageBox.Show("Please Select Eighther Date or TradeID");
                }
                
            }
            
        }
    }
}
