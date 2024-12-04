using MySql.Data.MySqlClient;


namespace TradingManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            starPass();
        }

        MySqlConnection con = DbConnection.connectDB();

        private void loginClear()
        {
            txtFirst.Text = string.Empty;
            txtLast.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == "" || txtLast.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Field Can Not be Empty !!");
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    con.Open();
                    String quarey = "INSERT INTO users (user_Fname,user_Lname,user_email,user_password) VALUES ('" + txtFirst.Text + "' , '" + txtLast.Text + "' ,'" + txtEmail.Text + "' ,'" + txtPassword.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(quarey, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Okay");
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password Confirmation Process Was Failed");
            }

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            this.loginClear();
            txtFirst.Focus();
        }


        private void starPass ()
        {
            if (ShowCheck.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            starPass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}



