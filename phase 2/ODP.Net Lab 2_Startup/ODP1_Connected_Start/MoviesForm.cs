using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODP1_Connected_Start
{
    public partial class MoviesForm : Form
    {
        private string ordb = "data source=orcl; user id=hr; password=hr;";
        //private string ordb = "data source=orcl; user id=scott; password=tiger;";
        private OracleConnection conn;
        private int userID;
        HelperFunctions helper;
        DataTable dt;
        OracleDataReader showsReader;
        public MoviesForm(int userID)
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
            this.userID = userID;
            category_txt.Hide();
        }
        public MoviesForm()
        {
            InitializeComponent();
            //this.userID = userID;
        }

        private void MoviesForm_Load_1(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            helper = new HelperFunctions();
            OracleDataReader dr = helper.RetrieveAllMovies(ref cmd);


            dt = new DataTable();
            
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;

            // filling movie name in a combo box 
            foreach (DataRow row in dt.Rows)
                movie_names_cmb.Items.Add(row[1].ToString());

            dr.Close();
        }




        private void MoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

       
        private string getCategorySelected(string name)
        {
            string cat = "N/A";
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == name)
                    return row[5].ToString();
            }
            return cat;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            category_txt.Show();
            string movieName = movie_names_cmb.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(movieName))
            {
                category_txt.Text += getCategorySelected(movieName);
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            showsReader = helper.RetrieveShowsForMovie(ref cmd, movieName);

            while (showsReader.Read())
            {
               // MessageBox.Show(showsReader[2]);
                show_date_cmb.Items.Add(showsReader[2].ToString());
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }


        // reserve button 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // seats combo box 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //start date combo box
        private void start_time_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // movies has been selected -> shows are availible 
            if (movie_names_cmb.SelectedItem != null) { 
            
            }

        }
        
        // dates combo box
        private void show_date_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
