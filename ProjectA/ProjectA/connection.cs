using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectA
{
    class connection
    {
        public SqlConnection connectio;
        public string conStr = "Data Source=DESKTOP-BA99OP5;Initial Catalog=ProjectA;Integrated Security=True";

        private static connection Instance;
        private connection()
        {

        }
        public static connection getInstance()
        {
            if (Instance == null)
            {
                Instance = new connection();
            }
            return Instance;
        }
        public SqlConnection getConnection()
        {
            connectio = new SqlConnection(conStr);

            if (connectio.State != System.Data.ConnectionState.Open)
            {
                connectio.Open();
            }
            return connectio;

        }

        public int executeQuery(string query)
        {
            connectio = getConnection();
            SqlCommand cmd = new SqlCommand(query, connectio);

            int rows = cmd.ExecuteNonQuery();
            return rows;

        }
        public SqlDataAdapter getData(string query)
        {

            SqlDataAdapter data = new SqlDataAdapter(query, getConnection());
            return data;
        }
        public void closeConnection()
        {
            if (connectio != null)
            {
                connectio.Close();
            }
        }

    }
}
