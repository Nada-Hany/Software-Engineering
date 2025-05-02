using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace ODP1_Connected_Start
{
    public partial class disconnectedForm_admin : Form
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public disconnectedForm_admin()
        {
            InitializeComponent();
        }

        private void disconnectedForm_admin_Load(object sender, EventArgs e)
        {
            string constr = "data source=orcl; user id=hr; password=hr;";
            string cmdstr = "select * from shows";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            string constr = "data source=orcl; user id=hr; password=hr;";
            string cmdstr = "select * from shows where showID= :id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", textBox1.Text);
            DataSet ds2 = new DataSet();
            adapter.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];

        }
    }
}
