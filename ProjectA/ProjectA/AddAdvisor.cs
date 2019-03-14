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
            if (con.State == System.Data.ConnectionState.Open)
            {
                if(cmbDesignation.SelectedIndex == 0)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('"+Convert.ToString(AdvisorID.Text)+"', '"+6+"', '"+Convert.ToInt32(Salary.Text)+"')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
                if (cmbDesignation.SelectedIndex == 1)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + Convert.ToString(AdvisorID.Text) + "', '" + 7 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
                if (cmbDesignation.SelectedIndex == 2)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + Convert.ToString(AdvisorID.Text) + "', '" + 8 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
                if (cmbDesignation.SelectedIndex == 3)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + Convert.ToString(AdvisorID.Text) + "', '" + 9 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }

                if (cmbDesignation.SelectedIndex == 4)
                {
                    Insert = "insert into Advisor(Id , Designation , Salary) values ('" + Convert.ToString(AdvisorID.Text) + "', '" + 10 + "', '" + Convert.ToInt32(Salary.Text) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Added");
                }
            }
        }

        private void Designation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
