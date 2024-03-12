using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace product
{
    public class AccesoDatos
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public AccesoDatos()
        {
            conn = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            cmd = new SqlCommand();
        }

        public void setQuery(string query)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
        }

        public void executeReader()
        {
            cmd.Connection = conn;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excecuteNonQuery()
        {
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setParameter(string name, object value)
        {
            cmd.Parameters.AddWithValue(name, value);
        }

        public void closeConnection()
        {
            if (reader != null)
            {
                reader.Close();
            }

            conn.Close();
        }
    }
}
