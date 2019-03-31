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
    public partial class CreateGroup : Form
    {
        public CreateGroup()
        {
            InitializeComponent();
        }

        public string conStr = "Data Source=DESKTOP-BA99OP5;Initial Catalog=ProjectA;Integrated Security=True";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string select;
            if (con.State == System.Data.ConnectionState.Open)
            {
                select = "select Title from Project";
                SqlDataAdapter data = new SqlDataAdapter(select, con);
                DataTable dt = new DataTable();

                data.Fill(dt);
                BindingSource src = new BindingSource();
                src.DataSource = dt;
                dataGridView1.DataSource = src;
            }
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
