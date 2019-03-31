using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string conStr = "Data Source=DESKTOP-BA99OP5;Initial Catalog=ProjectA;Integrated Security=True";

        private void btnlogin_Click(object sender, EventArgs e)
        {
            AddProject ad = new AddProject();
            this.Hide();
            ad.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Students f2 = new Students();
            f2.Show();
            this.Hide();
        }

        private void btnAdvisor_Click(object sender, EventArgs e)
        {
            AddAdvisor ad = new AddAdvisor();
            ad.Show();
            this.Hide();
        }

        private void btnEvaluation_Click(object sender, EventArgs e)
        {
            Evaluation ei = new Evaluation();
            ei.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateGroup c = new CreateGroup();
            c.Show();
        }
    }
}
