namespace TradingManagementApp.UserControls
{
    partial class UC_Income
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            label6 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            btnNew = new Button();
            label1 = new Label();
            txtPlanName = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.WindowFrame;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(176, 192);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(168, 20);
            txtTotal.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(69, 191);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 12;
            label6.Text = "Total Trades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(69, 145);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 14;
            label2.Text = "Plan Name";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Transparent;
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 207, 155);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.FromArgb(216, 165, 62);
            btnCalculate.Location = new Point(421, 162);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(103, 28);
            btnCalculate.TabIndex = 19;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Transparent;
            btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 207, 155);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.FromArgb(216, 165, 62);
            btnNew.Location = new Point(549, 162);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(103, 28);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(435, 45);
            label1.TabIndex = 25;
            label1.Text = "Calculate Expected Income";
            // 
            // txtPlanName
            // 
            txtPlanName.BackColor = SystemColors.WindowFrame;
            txtPlanName.BorderStyle = BorderStyle.None;
            txtPlanName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlanName.Location = new Point(176, 145);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(168, 20);
            txtPlanName.TabIndex = 13;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.WindowFrame;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(583, 213);
            dataGridView1.TabIndex = 26;
            // 
            // UC_Income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnNew);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(txtPlanName);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Name = "UC_Income";
            Size = new Size(728, 525);
            Load += UC_Income_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTotal;
        private Label label6;
        private Label label2;
        private Button btnCalculate;
        private Button btnNew;
        private Label label1;
        private TextBox txtPlanName;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
    }
}
