using PBL3___Cosmetics_Store_Management_App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Model
{
    internal class ExecuteDB : SingletonBase<ExecuteDB>
    {
        private SqlConnection connection;

        public ExecuteDB()
        {
            string s = @"Data Source=BENN\BEN;Initial Catalog=PBL3;Integrated Security=True";
            connection = new SqlConnection(s);
        }

        public int ExecuteNonQuery(string query, params SqlParameter[] p)
        {
            int result = 0;
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddRange(p);

                try
                {
                    connection.Open();
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return result;
            }
        }

        public DataTable ExecuteQuery(string  query, params SqlParameter[] p)
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddRange(p);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return dt;
        }

        public Object ExecuteScalar(string query, params SqlParameter[] p)
        {
            Object result = null;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddRange(p);

                try
                {
                    connection.Open();
                    result = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return result;
        }
    }
}
