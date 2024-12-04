namespace TradingManagementApp.UserControls
{
    partial class UC_History
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            btnReset3 = new Button();
            btnView3 = new Button();
            txtTradeID = new TextBox();
            label4 = new Label();
            label1 = new Label();
            DGVHistory = new DataGridView();
            dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGVHistory).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(35, 27);
            label2.Name = "label2";
            label2.Size = new Size(449, 45);
            label2.TabIndex = 29;
            label2.Text = "History is the Best Evidence";
            // 
            // btnReset3
            // 
            btnReset3.BackColor = Color.Transparent;
            btnReset3.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 165, 62);
            btnReset3.FlatStyle = FlatStyle.Flat;
            btnReset3.ForeColor = Color.FromArgb(216, 165, 62);
            btnReset3.Location = new Point(504, 134);
            btnReset3.Name = "btnReset3";
            btnReset3.Size = new Size(85, 28);
            btnReset3.TabIndex = 49;
            btnReset3.Text = "Reset";
            btnReset3.UseVisualStyleBackColor = false;
            btnReset3.Click += btnReset3_Click;
            // 
            // btnView3
            // 
            btnView3.BackColor = Color.Transparent;
            btnView3.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 207, 155);
            btnView3.FlatStyle = FlatStyle.Flat;
            btnView3.ForeColor = Color.FromArgb(216, 165, 62);
            btnView3.Location = new Point(504, 178);
            btnView3.Name = "btnView3";
            btnView3.Size = new Size(85, 28);
            btnView3.TabIndex = 48;
            btnView3.Text = "View";
            btnView3.UseVisualStyleBackColor = false;
            btnView3.Click += btnView3_Click;
            // 
            // txtTradeID
            // 
            txtTradeID.BackColor = SystemColors.WindowFrame;
            txtTradeID.BorderStyle = BorderStyle.None;
            txtTradeID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTradeID.Location = new Point(215, 181);
            txtTradeID.Name = "txtTradeID";
            txtTradeID.Size = new Size(191, 20);
            txtTradeID.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(112, 181);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 46;
            label4.Text = "Trade ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(112, 137);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 52;
            label1.Text = "Enter Date";
            // 
            // DGVHistory
            // 
            DGVHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVHistory.Location = new Point(68, 274);
            DGVHistory.Name = "DGVHistory";
            DGVHistory.RowTemplate.Height = 25;
            DGVHistory.Size = new Size(595, 217);
            DGVHistory.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.BackgroundImageLayout = ImageLayout.Stretch;
            dateTimePicker1.Checked = true;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.CustomizableEdges = customizableEdges1;
            dateTimePicker1.FillColor = SystemColors.WindowFrame;
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(215, 137);
            dateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dateTimePicker1.Size = new Size(191, 25);
            dateTimePicker1.TabIndex = 56;
            dateTimePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // UC_History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            Controls.Add(dateTimePicker1);
            Controls.Add(DGVHistory);
            Controls.Add(label1);
            Controls.Add(btnReset3);
            Controls.Add(btnView3);
            Controls.Add(txtTradeID);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "UC_History";
            Size = new Size(728, 525);
            Load += UC_History_Load;
            ((System.ComponentModel.ISupportInitialize)DGVHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnReset3;
        private Button btnView3;
        private TextBox txtTradeID;
        private Label label4;
        private Label label1;
        private DataGridView DGVHistory;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
    }
}
