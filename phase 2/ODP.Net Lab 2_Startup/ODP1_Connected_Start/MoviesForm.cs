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
        int movieIdSelected = -1;

        public MoviesForm(int userID)
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
            this.userID = userID;

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
          //  dataGridView1.ReadOnly = true;

  
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


        private void label18_Click(object sender, EventArgs e)
        {

        }


        // reserve button 
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            this.movieIdSelected = Convert.ToInt32(row.Cells["MOVIEID"].Value);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

        //   MessageBox.Show(this.movieIdSelected.ToString());

            showsReader = helper.RetrieveShowsForMovie(ref cmd, this.movieIdSelected);

            DataTable showsData;
            showsData = new DataTable();

            showsData.Load(showsReader);
            showsGrid.DataSource = showsData;


            showsReader.Close();

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = showsGrid.Rows[e.RowIndex];
            int showID = Convert.ToInt32(row.Cells[0].Value);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            show_price.Text = "Shows Price is: " + helper.getShowPrice(ref cmd, showID);
        }
    }
}
