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
    public partial class AddAdvisor : Form
    {
        public AddAdvisor()
        {
            InitializeComponent();
        }

        public string conStr = "Data Source=DESKTOP-BA99OP5;Initial Catalog=ProjectA;Integrated Security=True";

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string Insert;
            string mId;
            if (con.State == System.Data.ConnectionState.Open)
            {
                mId = "select max(Id) from Advisor";
                SqlCommand c = new SqlCommand(mId, con);

                int count = 0;
                count = int.Parse(c.ExecuteScalar().ToString());
                if(cmbDesignation.SelectedIndex == 0)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('"+(count+1)+"', '"+6+"', '"+Convert.ToInt32(Salary.Text)+"')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
                if (cmbDesignation.SelectedIndex == 1)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + (count + 1) + "', '" + 7 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
                if (cmbDesignation.SelectedIndex == 2)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + (count + 1) + "', '" + 8 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
                if (cmbDesignation.SelectedIndex == 3)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + (count + 1) + "', '" + 9 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }

                if (cmbDesignation.SelectedIndex == 4)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + (count + 1) + "', '" + 10 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
            }
        }

        private void Designation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddAdvisor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string select;
            if (con.State == System.Data.ConnectionState.Open)
            {
                select = "select Designation, Salary from Advisor";
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
