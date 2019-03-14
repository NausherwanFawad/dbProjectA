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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conStr = "Data Source=DESKTOP-BA99OP5;Initial Catalog=ProjectA;Integrated Security=True";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string Insert;
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Insert = "insert into Person(FirstName, LastName,Contact,Email, DateOfBirth, Gender) values ('"+Convert.ToString(FirstName.Text)+"' , '"+Convert.ToString(LastName.Text)+"' , '"+Convert.ToString(Contact.Text)+"' , '"+Convert.ToString(Email.Text)+"' , '"+Convert.ToDateTime(DateOfBirth.Value)+"' , '"+1+"')";
                }
                else
                {
                    Insert = "insert into Person(FirstName, LastName,Contact,Email, DateOfBirth, Gender) values ('" + Convert.ToString(FirstName.Text) + "' , '" + Convert.ToString(LastName.Text) + "' , '" + Convert.ToString(Contact.Text) + "' , '" + Convert.ToString(Email.Text) + "' , '" + Convert.ToDateTime(DateOfBirth.Value) + "' , '" + 2 + "')";
                }
                SqlCommand sqlcmd = new SqlCommand(Insert, con);
                sqlcmd.ExecuteNonQuery();
                int id;
                sqlcmd.CommandText = "Select @@identity";
                id = Convert.ToInt32(sqlcmd.ExecuteScalar());
                string studentinsert = "insert into Student(Id, RegistrationNo) values ('"+id+"' , '"+Convert.ToString(RegisterationNo.Text)+"')";
                SqlCommand cmd = new SqlCommand(studentinsert , con);
                cmd.ExecuteNonQuery();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
