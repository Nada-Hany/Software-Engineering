using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class MainMenuForm : Form
    {
        int userID;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        public MainMenuForm(int id )
        {
            InitializeComponent();
            this.userID = id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
          //  Form1 reportForm = new Form1();
            Form2 reportForm = new Form2();
            this.Hide(); // Hide LoginForm
            reportForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm(userID);
            this.Hide(); // Hide LoginForm
            moviesForm.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 reportform = new Form1();
            this.Hide(); // Hide LoginForm
            reportform.Show();
        }
    }
}
