namespace TradingManagementApp
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPass = new TextBox();
            label5 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ShowCheck = new CheckBox();
            btnBackSignup = new Button();
            label7 = new Label();
            btnClear1 = new Button();
            btnLog = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(230, 231, 233);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(21, 291);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(340, 29);
            txtPass.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(18, 266);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(230, 231, 233);
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(21, 227);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(340, 29);
            txtMail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(13, 202);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = " Email";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(346, 9);
            button2.Name = "button2";
            button2.Size = new Size(25, 25);
            button2.TabIndex = 29;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(216, 165, 62);
            label3.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(133, 70);
            label3.Name = "label3";
            label3.Size = new Size(28, 31);
            label3.TabIndex = 28;
            label3.Text = "T";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(154, 61);
            label2.Name = "label2";
            label2.Size = new Size(98, 50);
            label2.TabIndex = 27;
            label2.Text = "Plan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_TPlan;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // ShowCheck
            // 
            ShowCheck.AutoSize = true;
            ShowCheck.ForeColor = Color.Gray;
            ShowCheck.Location = new Point(249, 341);
            ShowCheck.Name = "ShowCheck";
            ShowCheck.Size = new Size(118, 21);
            ShowCheck.TabIndex = 30;
            ShowCheck.Text = "Show Password";
            ShowCheck.UseVisualStyleBackColor = false;
            ShowCheck.CheckedChanged += ShowCheck_CheckedChanged;
            // 
            // btnBackSignup
            // 
            btnBackSignup.BackColor = Color.FromArgb(216, 165, 62);
            btnBackSignup.FlatAppearance.BorderSize = 0;
            btnBackSignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(179, 88, 1);
            btnBackSignup.FlatStyle = FlatStyle.Flat;
            btnBackSignup.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackSignup.ForeColor = Color.White;
            btnBackSignup.Location = new Point(21, 470);
            btnBackSignup.Name = "btnBackSignup";
            btnBackSignup.Size = new Size(340, 35);
            btnBackSignup.TabIndex = 34;
            btnBackSignup.Text = "Back to Sign up";
            btnBackSignup.UseVisualStyleBackColor = false;
            btnBackSignup.Click += btnBackSignup_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(113, 437);
            label7.Name = "label7";
            label7.Size = new Size(169, 20);
            label7.TabIndex = 33;
            label7.Text = "I Don't Have an Account";
            // 
            // btnClear1
            // 
            btnClear1.FlatAppearance.MouseDownBackColor = Color.FromArgb(179, 88, 1);
            btnClear1.FlatStyle = FlatStyle.Flat;
            btnClear1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear1.Location = new Point(202, 386);
            btnClear1.Name = "btnClear1";
            btnClear1.Size = new Size(102, 35);
            btnClear1.TabIndex = 32;
            btnClear1.Text = "Clear";
            btnClear1.UseVisualStyleBackColor = true;
            btnClear1.Click += btnClear1_Click;
            // 
            // btnLog
            // 
            btnLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(179, 88, 1);
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLog.Location = new Point(78, 386);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(102, 35);
            btnLog.TabIndex = 31;
            btnLog.Text = "Log in";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.instagram;
            pictureBox6.Location = new Point(211, 543);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.twitter;
            pictureBox5.Location = new Point(278, 543);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 37;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.youtube;
            pictureBox4.Location = new Point(144, 543);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.facebook;
            pictureBox2.Location = new Point(72, 543);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(105, 132);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 39;
            label1.Text = "Ready to Log in";
            label1.Click += label1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(378, 611);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(btnBackSignup);
            Controls.Add(label7);
            Controls.Add(btnClear1);
            Controls.Add(btnLog);
            Controls.Add(ShowCheck);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtPass);
            Controls.Add(label5);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(216, 165, 62);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private Label label5;
        private TextBox txtMail;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox ShowCheck;
        private Button btnBackSignup;
        private Label label7;
        private Button btnClear1;
        private Button btnLog;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Label label1;
    }
}