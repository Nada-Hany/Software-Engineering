using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODP1_Connected_Start
{
    public partial class adminForm : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        public adminForm()
        {
            InitializeComponent();
        }

   
       

        private void addMovies_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CategoryID from MovieCategory";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                //MessageBox.Show("cat inserted successfully!");
            }
            dr.Close();
            panel2.BringToFront();

        }

    
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

    
    

    
   
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


  
        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select MovieName from Movies";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
                MessageBox.Show("names inserted successfully!");
            }
            dr.Close();
            MessageBox.Show("noooo names inserted successfully!");
            panel4.BringToFront();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select MovieName from Movies";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0]);
                MessageBox.Show("show shows inserted successfully!");
            }
            dr.Close();

            string sql = "SELECT * FROM Shows"; //WHERE ShowDayDate = TRUNC(SYSDATE) AND startTime <= SYSTIMESTAMP

            OracleCommand cmdd = new OracleCommand(sql);
            OracleDataAdapter adapter = new OracleDataAdapter(cmdd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            panel5.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Movies (MovieID,MovieName, MovieDuration, MovieRate, ReleaseDate, MovieCategoryID) VALUES(MovieID_Seq.NEXTVAL,:MovieName, :MovieDuration, :MovieRate, :ReleaseDate, :MovieCategoryID)";

            cmd.Parameters.Add("MovieName", textBox1.Text);
            cmd.Parameters.Add("MovieDuration", textBox2.Text);
            cmd.Parameters.Add("MovieRate", textBox3.Text);
            cmd.Parameters.Add("ReleaseDate", dateTimePicker1.Value); // Directly pass DateTime
            cmd.Parameters.Add("MovieCategoryID", comboBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1) MessageBox.Show("Movie inserted successfully!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Shows (ShowID, MovieName, ShowDayDate, startTime, numberOfSeats, available_seats, Price) VALUES(ShowId_Seq.NEXTVAL, :MovieName, :ShowDayDate, :startTime, :numberOfSeats, :numberOfSeats, :Price)";

            cmd.Parameters.Add("MovieName", comboBox2.Text);
            cmd.Parameters.Add("numberOfSeats", textBox4.Text);
            cmd.Parameters.Add("Price", textBox5.Text);
            cmd.Parameters.Add("ShowDayDate", dateTimePicker2.Value.Date); // Directly pass DateTime
            cmd.Parameters.Add("startTime", dateTimePicker3.Value.TimeOfDay);
            int r = cmd.ExecuteNonQuery();
            if (r != -1) MessageBox.Show("show inserted successfully!");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conn;
            //cmd.CommandText= "SELECT * FROM Shows where MovieName=:name";
            //cmd.Parameters.Add("name", comboBox3.Text);
        }

        // add movies button
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        // add show button
        private void button2_Click_1(object sender, EventArgs e)
        {

            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select MovieName from Movies";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
                //MessageBox.Show("names inserted successfully!");
            }
            dr.Close();

            panel4.BringToFront();
        }

        // shows button
        private void button11_Click(object sender, EventArgs e)
        {

        }


        // home button
        private void button6_Click_1(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
