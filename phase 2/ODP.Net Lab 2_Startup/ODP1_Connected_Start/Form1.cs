using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace ODP1_Connected_Start
{
    public partial class Form1 : Form
    {
        CrystalReport1 CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            crystalReportViewer1.ReportSource = CR;
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                category_cmb.Items.Add(v.Value);
            CR.SetParameterValue(0, category_cmb.Text);
            CR.SetParameterValue(1, Convert.ToDateTime(startDate_picker.Text));
            CR.SetParameterValue(2, Convert.ToDateTime(endDate_picker.Text));
        }



        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
