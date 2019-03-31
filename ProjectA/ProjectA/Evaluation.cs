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
                Evaluation ea = new Evaluation();
                ea.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[selected];
            int id = (int)r.Cells[1].Value;
            if (e.ColumnIndex == 0)
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "Delete from Evaluation where Id = '" + id + "'";
                    SqlCommand s = new SqlCommand(query, con);
                    s.ExecuteNonQuery();
                    //string query1 = "Delete from Person where Id = '" + id + "'";
                    //SqlCommand sq = new SqlCommand(query1, con);
                    //sq.ExecuteNonQuery();
                }
                MessageBox.Show("Succesfully Deleted");
                Evaluation ap = new Evaluation() ;
                this.Close();
                ap.Show();
            }
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string select;
            if (con.State == System.Data.ConnectionState.Open)
            {
                select = "select * from Evaluation";
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
