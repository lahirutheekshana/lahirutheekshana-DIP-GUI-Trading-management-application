namespace TradingManagementApp.UserControls
{
    partial class UC_CreatePlan
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
            label1 = new Label();
            label6 = new Label();
            txtStart = new TextBox();
            txtTypicalRisk = new TextBox();
            label2 = new Label();
            txtRisk = new TextBox();
            label5 = new Label();
            txtWin = new TextBox();
            label7 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            btnUpdate = new Button();
            txtName = new TextBox();
            label4 = new Label();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            DataGrid = new DataGridView();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(481, 45);
            label1.TabIndex = 8;
            label1.Text = "Create Your Own Trading Plan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(56, 114);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 10;
            label6.Text = "Account Start";
            // 
            // txtStart
            // 
            txtStart.BackColor = SystemColors.WindowFrame;
            txtStart.BorderStyle = BorderStyle.None;
            txtStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStart.Location = new Point(163, 115);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(168, 20);
            txtStart.TabIndex = 11;
            // 
            // txtTypicalRisk
            // 
            txtTypicalRisk.BackColor = SystemColors.WindowFrame;
            txtTypicalRisk.BorderStyle = BorderStyle.None;
            txtTypicalRisk.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTypicalRisk.Location = new Point(493, 115);
            txtTypicalRisk.Name = "txtTypicalRisk";
            txtTypicalRisk.Size = new Size(168, 20);
            txtTypicalRisk.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(382, 114);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 12;
            label2.Text = "Typical Risk(%)";
            // 
            // txtRisk
            // 
            txtRisk.BackColor = SystemColors.WindowFrame;
            txtRisk.BorderStyle = BorderStyle.None;
            txtRisk.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRisk.Location = new Point(163, 167);
            txtRisk.Name = "txtRisk";
            txtRisk.Size = new Size(168, 20);
            txtRisk.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(56, 166);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 14;
            label5.Text = "Risk Reward";
            // 
            // txtWin
            // 
            txtWin.BackColor = SystemColors.WindowFrame;
            txtWin.BorderStyle = BorderStyle.None;
            txtWin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWin.Location = new Point(493, 167);
            txtWin.Name = "txtWin";
            txtWin.Size = new Size(168, 20);
            txtWin.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(382, 167);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 16;
            label7.Text = "Win/Loss(%)";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 207, 155);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(216, 165, 62);
            btnSave.Location = new Point(164, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 28);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 165, 62);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.FromArgb(216, 165, 62);
            btnReset.Location = new Point(571, 299);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 28);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 165, 62);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(216, 165, 62);
            btnUpdate.Location = new Point(266, 299);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 28);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.WindowFrame;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(348, 228);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 20);
            txtName.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(258, 228);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 23;
            label4.Text = "Plan Name";
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Transparent;
            btnDeleteAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 165, 62);
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.ForeColor = Color.FromArgb(216, 165, 62);
            btnDeleteAll.Location = new Point(470, 299);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(85, 28);
            btnDeleteAll.TabIndex = 25;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 165, 62);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(216, 165, 62);
            btnDelete.Location = new Point(368, 299);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 28);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // DataGrid
            // 
            DataGrid.BackgroundColor = SystemColors.WindowFrame;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(56, 349);
            DataGrid.Name = "DataGrid";
            DataGrid.RowTemplate.Height = 25;
            DataGrid.Size = new Size(605, 161);
            DataGrid.TabIndex = 26;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Transparent;
            btnView.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 207, 155);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.ForeColor = Color.FromArgb(216, 165, 62);
            btnView.Location = new Point(62, 299);
            btnView.Name = "btnView";
            btnView.Size = new Size(85, 28);
            btnView.TabIndex = 27;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // UC_CreatePlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            Controls.Add(btnView);
            Controls.Add(DataGrid);
            Controls.Add(btnDeleteAll);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(txtWin);
            Controls.Add(label7);
            Controls.Add(txtRisk);
            Controls.Add(label5);
            Controls.Add(txtTypicalRisk);
            Controls.Add(label2);
            Controls.Add(txtStart);
            Controls.Add(label6);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "UC_CreatePlan";
            Size = new Size(728, 525);
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label6;
        private TextBox txtStart;
        private TextBox txtTypicalRisk;
        private Label label2;
        private TextBox txtRisk;
        private Label label5;
        private TextBox txtWin;
        private Label label7;
        private Button btnSave;
        private Button btnReset;
        private Button btnUpdate;
        private TextBox txtName;
        private Label label4;
        private Button btnDeleteAll;
        private Button btnDelete;
        private DataGridView DataGrid;
        private Button btnView;
    }
}
