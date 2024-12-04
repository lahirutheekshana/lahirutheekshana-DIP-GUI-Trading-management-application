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
using System.Xml.Linq;

namespace TradingManagementApp.UserControls
{
    public partial class UC_Income : UserControl
    {
        String currentEmail = "";
        int user_id = 0;



        int plan_id = 0;
        double AccStart = 0.0;
        int typicalRisk = 0;
        double RiskReward = 0.0;
        int win_loss = 0;

        MySqlConnection con = DbConnection.connectDB();


        public UC_Income(String currentEmail)
        {
            InitializeComponent();
            this.currentEmail = currentEmail;
            GetUser_Id();
        }



        private void populateGrid()
        {
            con.Open();
            String selectQuery = "SELECT * FROM income";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            con.Close();
        }



        private void GetUser_Id()
        {
            try
            {
                con.Open();
                String quarey = "SELECT user_id FROM users WHERE user_email = @email";
                MySqlCommand cmd = new MySqlCommand(quarey, con);
                cmd.Parameters.AddWithValue("@email", currentEmail);
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
            con.Close();

        }



        private void getPlanInfo()
        {
            String quarey1 = "SELECT P_AccStart FROM plan WHERE P_Name = @PName";
            String quarey2 = "SELECT P_TypicalRisk FROM plan WHERE P_Name = @PName";
            String quarey3 = "SELECT P_RiskReward FROM plan WHERE P_Name = @PName";
            String quarey4 = "SELECT P_win_loss FROM plan WHERE P_Name = @PName";
            String quarey5 = "SELECT P_ID FROM plan WHERE P_Name = @PName";


            try
            {
                con.Open();
                MySqlCommand cmd1 = new MySqlCommand(quarey1, con);
                cmd1.Parameters.AddWithValue("@PName", txtPlanName.Text);
                object result1 = cmd1.ExecuteScalar();

                if (result1 != null)
                {
                    AccStart = Convert.ToDouble(result1);
                }

                MySqlCommand cmd2 = new MySqlCommand(quarey2, con);
                cmd2.Parameters.AddWithValue("@PName", txtPlanName.Text);
                object result2 = cmd2.ExecuteScalar();

                if (result2 != null)
                {
                    typicalRisk = Convert.ToInt32(result2);
                }

                MySqlCommand cmd3 = new MySqlCommand(quarey3, con);
                cmd3.Parameters.AddWithValue("@PName", txtPlanName.Text);
                object result3 = cmd3.ExecuteScalar();

                if (result3 != null)
                {
                    RiskReward = Convert.ToInt32(result3);
                }

                MySqlCommand cmd4 = new MySqlCommand(quarey4, con);
                cmd4.Parameters.AddWithValue("@PName", txtPlanName.Text);
                object result4 = cmd4.ExecuteScalar();

                if (result4 != null)
                {
                    win_loss = Convert.ToInt32(result4);
                }

                MySqlCommand cmd5 = new MySqlCommand(quarey5, con);
                cmd5.Parameters.AddWithValue("@PName", txtPlanName.Text);
                object result5 = cmd5.ExecuteScalar();

                if (result5 != null)
                {
                    plan_id = Convert.ToInt32(result5);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }










        private void FillIncomeTable(double balance, double profit, double newBalance)
        {
            try
            {
                con.Open();
                String quarey = "INSERT INTO income (I_Balance,I_profit_Loss,I_NewBalance,user_id,P_id) VALUES (@balance, @profit ,@newBalance ,@userid ,@p_id)";
                MySqlCommand cmd = new MySqlCommand(quarey, con);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@profit", profit);
                cmd.Parameters.AddWithValue("@newBalance", newBalance);
                cmd.Parameters.AddWithValue("@p_id", plan_id);
                cmd.Parameters.AddWithValue("@userid", user_id);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            deleteData();
            if(txtPlanName.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Please Make Sure All the fields are inserted");
            }
            else
            {
                getPlanInfo();

                int nu_trades = Convert.ToInt32(txtTotal.Text);
                double balance = 0.0;
                double profit = 0;
                double newBalance = 0;

                int x = (win_loss / 100) * nu_trades;
                int y = nu_trades - x;
                int even_count = 0;
                int odd_count = 0;

                Random random = new Random();
                

                for (int i = 0; i < nu_trades; i++)
                {
                    int randomNumber = random.Next(1, 3);

                    if(even_count == x)
                    {
                        randomNumber++;
                    }

                    if (odd_count == y)
                    {
                        randomNumber++;
                    }


                    if (randomNumber % 2 == 0)
                    {     
                            if (i == 0)
                            {
                                balance = AccStart;
                            }
                            else
                            {
                                balance = newBalance;
                            }
                            profit = ((balance * typicalRisk) / 100) * RiskReward;
                            newBalance = balance + profit;
                            even_count += 1;  
                    }

                    else
                    {
                            if (i == 0)
                            {
                                balance = AccStart;
                            }
                            else
                            {
                                balance = newBalance;
                            }
                            profit = ((balance * typicalRisk) / 100);
                            newBalance = balance - profit;
                            odd_count += 1;
                        
                    }
                    FillIncomeTable(balance, profit, newBalance);
                    populateGrid();
                }
                
            }

        }


        private void deleteData()
        {
            try
            {
                con.Open();
                String quarey = "DELETE FROM income WHERE user_id = @userid ";
                MySqlCommand cmd = new MySqlCommand(quarey, con);
                cmd.Parameters.AddWithValue("@userid", user_id);
                cmd.ExecuteNonQuery();
                con.Close();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String quarey = "DELETE FROM income WHERE user_id = @userid ";
                MySqlCommand cmd = new MySqlCommand(quarey, con);
                cmd.Parameters.AddWithValue("@userid", user_id);
                cmd.ExecuteNonQuery();
                con.Close();
                txtPlanName.Text = "";
                txtTotal.Text = "";
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

        private void UC_Income_Load(object sender, EventArgs e)
        {

        }
    }
}
