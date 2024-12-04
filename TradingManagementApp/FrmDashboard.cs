using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingManagementApp.UserControls;

namespace TradingManagementApp
{
    public partial class FrmDashboard : Form
    {
        String mail = "";
        public FrmDashboard(String email)
        {
            InitializeComponent();
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
            mail = email;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_CreatePlan uc = new UC_CreatePlan(mail);
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Income uc = new UC_Income(mail);
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Track uc = new UC_Track(mail);
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_Confirm uc = new UC_Confirm();
            addUserControl(uc);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_History uc = new UC_History();
            addUserControl(uc);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
            
        }
    }
}
