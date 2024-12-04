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
    public partial class UC_Confirm : UserControl
    {
        public UC_Confirm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            lblChart.Text = String.Empty;
            lblCandle.Text = String.Empty;
            lblSession.Text = String.Empty;
            lblKey.Text = String.Empty;
            lblTrend.Text = String.Empty;
            lblFib.Text = String.Empty;
            lblTime.Text = String.Empty;
            lblBreak.Text = String.Empty;
        }

        private void btnCandleReady_Click(object sender, EventArgs e)
        {
            lblCandle.Text = "Ready";
            lblCandle.ForeColor = Color.Green;
        }

        private void btnCandleNotReady_Click(object sender, EventArgs e)
        {
            lblCandle.Text = "Wait";
            lblCandle.ForeColor = Color.Red;
        }

        private void btnChartReady_Click(object sender, EventArgs e)
        {
            lblChart.Text = "Ready";
            lblChart.ForeColor = Color.Green;
        }

        private void btnChartNotReady_Click(object sender, EventArgs e)
        {
            lblChart.Text = "Wait";
            lblChart.ForeColor = Color.Red;
        }

        private void btnSessionReady_Click(object sender, EventArgs e)
        {
            lblSession.Text = "Ready";
            lblSession.ForeColor = Color.Green;
        }

        private void btnSessionNotReady_Click(object sender, EventArgs e)
        {
            lblSession.Text = "Wait";
            lblSession.ForeColor = Color.Red;
        }

        private void btnKeyReady_Click(object sender, EventArgs e)
        {
            lblKey.Text = "Ready";
            lblKey.ForeColor = Color.Green;
        }

        private void btnKeyNotReady_Click(object sender, EventArgs e)
        {
            lblKey.Text = "Wait";
            lblKey.ForeColor = Color.Red;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lblTrend.Text = "Up";
            lblTrend.ForeColor = Color.Green;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            lblTrend.Text = "Down";
            lblTrend.ForeColor = Color.Red;
        }

        private void btnFibReady_Click(object sender, EventArgs e)
        {
            lblFib.Text = "Ready";
            lblFib.ForeColor = Color.Green;
        }

        private void btnFibNotReady_Click(object sender, EventArgs e)
        {
            lblFib.Text = "Wait";
            lblFib.ForeColor = Color.Red;
        }

        private void btnTimeReady_Click(object sender, EventArgs e)
        {
            lblTime.Text = "Ready";
            lblTime.ForeColor = Color.Green;
        }

        private void btnTimeNotReady_Click(object sender, EventArgs e)
        {
            lblTime.Text = "Wait";
            lblTime.ForeColor = Color.Red;
        }

        private void btnBreakReady_Click(object sender, EventArgs e)
        {
            lblBreak.Text = "Ready";
            lblBreak.ForeColor = Color.Green;
        }

        private void btnBreakNotReady_Click(object sender, EventArgs e)
        {
            lblBreak.Text = "Wait";
            lblBreak.ForeColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            init();
        }

        private void lblTrend_Click(object sender, EventArgs e)
        {

        }
    }
}
