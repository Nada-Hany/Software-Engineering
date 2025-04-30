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
        private string ordb = "data source=orcl; user id=scott; password=tiger;";
        private OracleConnection conn;
        private int userID;

        public MoviesForm(int userID)
        {
            InitializeComponent();
            this.userID = userID; 
        }
        public MoviesForm()
        {
            InitializeComponent();
            //this.userID = userID;
        }

        private void MoviesForm_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMoviesByCategory";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_categoryID", OracleDbType.Int32).Value = Convert.ToInt32(categoryComboBox.SelectedIndex);
            cmd.Parameters.Add("p_movies_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
          
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
        }



        private void MoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a valid category is selected
            if (categoryComboBox.SelectedValue == null || categoryComboBox.SelectedIndex == -1)
                return;

            int categoryID;
            try
            {
                categoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
            }
            catch
            {
                return; // Ignore invalid selections
            }

           
        }
        
    }
}
