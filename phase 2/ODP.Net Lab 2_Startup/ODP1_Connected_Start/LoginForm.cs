using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{
    public partial class LoginForm : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        HelperFunctions helper;
        public LoginForm()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void ActorsForm_Load(object sender, EventArgs e)
        {
        }


        private void ActorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password_txt.Text)|| string.IsNullOrEmpty(username_txt.Text))
                return;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            helper = new HelperFunctions();
            if (username_txt.Text.ToString() == "admin" && password_txt.Text.ToString() == "admin")
            {
                //MessageBox.Show("admoon", "admoon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminForm admin = new adminForm();
                this.Hide(); // Hide LoginForm
                admin.Show();

            }
            else {
                int userID = helper.UserExists(username_txt.Text.ToString(), password_txt.Text.ToString(), ref cmd);

                if (userID != -1)
                {
                    MoviesForm moviesForm = new MoviesForm(userID);
                    this.Hide(); // Hide LoginForm
                    moviesForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

  
    }
}
