using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class UC_Track : UserControl
    {

        MySqlConnection con = DbConnection.connectDB();

        String current_email = "";
        int user_id = 0;

        public UC_Track(String email)
        {
            InitializeComponent();
            current_email = email;
            GetUser_Id();
            populateCombo();
        }


        private void populateCombo()
        {
            cmbWonLoss.Items.Clear();
            cmbWonLoss.Items.Add("Win");
            cmbWonLoss.Items.Add("Loss");

            cmbBuySell.Items.Clear();
            cmbBuySell.Items.Add("Buy");
            cmbBuySell.Items.Add("Sell");
        }


        private void populateGrid()
        {
            try
            {
                con.Open();
                String selectQuery = "SELECT * FROM trade";
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Refresh();

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



        private void GetUser_Id()
        {
            try
            {
                con.Open();
                String quarey = "SELECT user_id FROM users WHERE user_email = @email";
                MySqlCommand cmd = new MySqlCommand(quarey, con);
                cmd.Parameters.AddWithValue("@email", current_email);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    user_id = Convert.ToInt32(result);
                }

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




        private void FillTradeTable()
        {
            try
            {
                con.Open();
                String quarey = "INSERT INTO trade (T_Capital,T_Market,T_RiskAmount,T_WinLoss,T_BuySell,user_id) VALUES (@capital ,@Market ,@RiskAmount ,@WinLoss,@BuySell,@userid)";
                MySqlCommand cmd = new MySqlCommand(quarey, con);
                cmd.Parameters.AddWithValue("@capital", Convert.ToDouble(txtCapital1.Text));
                cmd.Parameters.AddWithValue("@Market", txtMarket1.Text);
                cmd.Parameters.AddWithValue("@RiskAmount", Convert.ToDouble(txtRiskAmount1.Text));
                cmd.Parameters.AddWithValue("@userid", user_id);


                String status1 = cmbWonLoss.SelectedItem.ToString();
                String status2 = cmbBuySell.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@WinLoss", status1);
                cmd.Parameters.AddWithValue("@BuySell", status2);


                cmd.ExecuteNonQuery();
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


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRiskAmount1.Text == "" || txtCapital1.Text == "" || txtMarket1.Text == "" || txtRiskRatio.Text == "")
            {                   

                MessageBox.Show("Make Sure all Fields are inserted");
            }
            else
            {
                if (cmbWonLoss.SelectedIndex == -1 || cmbBuySell.SelectedIndex == -1)
                {
                    MessageBox.Show("Make Sure all Fields are inserted");
                }
                else
                {
                    FillTradeTable();
                    populateGrid();
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtRiskAmount1.Text = "";
            txtCapital1.Text = "";
            txtMarket1.Text = "";
            txtRiskRatio.Text = "";
            cmbWonLoss.SelectedIndex = -1;
            cmbBuySell.SelectedIndex = -1;
        }
    }
}
