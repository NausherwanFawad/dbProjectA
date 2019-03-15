using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
        }
        public string conStr = "Data Source=DESKTOP-BA99OP5;Initial Catalog=ProjectA;Integrated Security=True";

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string Insert;
            if (con.State == System.Data.ConnectionState.Open)
            {
                Insert = string.Format("insert into Evaluation( Name,TotalMarks, TotalWeightage) values ( '{0}',{1},{2} )",txtName.Text,Convert.ToInt32(txtMarks.Text),Convert.ToInt32(txtWeightage.Text));
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evaluation Added in DataBase");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string select;
            if (con.State == System.Data.ConnectionState.Open)
            {
                select = "select Name,TotalMarks, TotalWeightage from Evaluation";
                SqlDataAdapter data = new SqlDataAdapter(select, con);
                DataTable dt = new DataTable();

                data.Fill(dt);
                BindingSource src = new BindingSource();
                src.DataSource = dt;
                dataGridView1.DataSource = src;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
