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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        public string conStr = "Data Source=DESKTOP-BA99OP5;Initial Catalog=ProjectA;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string Insert;
            if (con.State == System.Data.ConnectionState.Open)
            {
                Insert = "insert into Project( Description, Title) values ( '"+Convert.ToString(txtDerscription.Text)+ "' , '" + Convert.ToString(txtprojecttitle.Text) + "' )";
                SqlCommand cmd = new SqlCommand(Insert, con);
                cmd.ExecuteNonQuery();
                
            }
            MessageBox.Show("Project Added in DataBase");
            AddProject ap = new AddProject();
            this.Close();
            ap.Show();

        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string select;
            if (con.State == System.Data.ConnectionState.Open)
            {
                select = "select * from Project";
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
        int selected;
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[selected];
            id = (int)r.Cells[1].Value;
            if(e.ColumnIndex == 0)
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "Delete from Project where Id = '" + id + "'";
                    SqlCommand s = new SqlCommand(query, con);
                    s.ExecuteNonQuery();
                }
                MessageBox.Show("Succesfully Deleted");
                AddProject ap = new AddProject();
                this.Close();
                ap.Show();
            }
        }
    }
}
