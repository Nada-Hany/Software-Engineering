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
    public partial class Form2 : Form
    {
        CrystalReport2 CR;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                category_cmb.Items.Add(v.Value);
     
        }

        private void category_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, category_cmb.Text);
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
