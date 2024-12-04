using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TradingManagementApp.UserControls
{
    public partial class UC_CreatePlan : UserControl
    {
        String currentEmail = "";
        int user_id = 0;
        public UC_CreatePlan(String Mail)
        {
            InitializeComponent();
            currentEmail = Mail;
            GetUserId();
        }



        MySqlConnection con = DbConnection.connectDB();

        private void populateGrid()
        {
            try
            {
                con.Open();
                String selectQuery = "SELECT * FROM plan WHERE user_id = @userid";
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@userid", user_id);

                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DataGrid.DataSource = ds.Tables[0];
            }
            catch(MySqlException  ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void GetUserId()
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
            finally
            {
                con.Close();
            }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtRisk.Text == "" || txtStart.Text == "" || txtTypicalRisk.Text == "" || txtWin.Text == "")
            {
                MessageBox.Show("Missing Informations, Check Again");
            }
            else
            {
                try
                {
                    con.Open();
                    String quarey = "INSERT INTO plan (P_Name,P_AccStart,P_TypicalRisk,P_RiskReward,P_win_loss,user_id) VALUES (@Name, @Start, @TypicalRisk ,@Risk, @win,@userid)";
                    MySqlCommand cmd = new MySqlCommand(quarey, con);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Start", double.Parse(txtStart.Text));
                    cmd.Parameters.AddWithValue("@TypicalRisk", int.Parse(txtTypicalRisk.Text));
                    cmd.Parameters.AddWithValue("@Risk", int.Parse(txtRisk.Text));
                    cmd.Parameters.AddWithValue("@win", int.Parse(txtWin.Text));
                    cmd.Parameters.AddWithValue("@userid", user_id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Plan Saved Successfully");                   
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
            populateGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtRisk.Text == "" || txtStart.Text == "" || txtTypicalRisk.Text == "" || txtWin.Text == "")
            {
                MessageBox.Show("Missing Informations, Check Again");
            }
            else
            {
                try
                {
                    con.Open();
                    String quarey = "UPDATE plan SET P_Date = now() , P_AccStart = '" + txtStart.Text + "' ,P_TypicalRisk = '" + txtTypicalRisk.Text + "',P_RiskReward = '" + txtRisk.Text + "'  ,P_win_loss = '" + txtWin.Text + "' WHERE P_Name ='" + txtName.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(quarey, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Okay");
                    
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRisk.Text == "" && txtWin.Text == "" && txtStart.Text == "" && txtTypicalRisk.Text == "")
            {
                try
                {

                    con.Open();
                    String quarey = "DELETE FROM Plan WHERE P_Name = '" + txtName.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(quarey, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Okay");
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
            else
            {
                MessageBox.Show("Only Plan Name is Required");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtRisk.Text = String.Empty;
            txtStart.Text = String.Empty;
            txtTypicalRisk.Text = String.Empty;
            txtWin.Text = String.Empty;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            if (txtRisk.Text == "" && txtWin.Text == "" && txtStart.Text == "" && txtTypicalRisk.Text == "")
            {
                try
                {
                    con.Open();
                    String quarey = "DELETE FROM plan WHERE user_id = @userid ";
                    MySqlCommand cmd = new MySqlCommand(quarey, con);
                    cmd.Parameters.AddWithValue("@userid", user_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("All the plans has been Deleted");
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
            else
            {
                MessageBox.Show("Only Plan Name is Required");
            }


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            populateGrid();
        }
    }
}
