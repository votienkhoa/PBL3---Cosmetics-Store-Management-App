using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Models
{
    internal class Category_Model : SingletonBase<Category_Model>
    {
        public DataTable GetData()
        {
            string sql = "SELECT * FROM categories";
            return ExecuteDB.Instance.ExecuteQuery(sql);
        }

        public DataTable GetData(SqlParameter name, SqlParameter id)
        {
            string sql = "SELECT * FROM categories " +
                         "WHERE category_name LIKE @nameSearch " +
                         "OR category_ID LIKE @idSearch";
            return ExecuteDB.Instance.ExecuteQuery(sql, name, id);
        }

        public void Add(SqlParameter p)
        {
            string sql = "INSERT INTO categories (category_name) " +
                         "VALUES (@category_name)";


            if (ExecuteDB.Instance.ExecuteNonQuery(sql, p) > 0) MessageBox.Show("Save Successfully!");
            else MessageBox.Show("Save Failed!");
            
        }

        public void Delete(SqlParameter p)
        {
            string sql = "DELETE FROM categories WHERE category_ID = @category_id";

            if (ExecuteDB.Instance.ExecuteNonQuery(sql, p) > 0) MessageBox.Show("Delete Successfully!");
            else MessageBox.Show("Delete Failed!");
        }

        public void Update(SqlParameter id, SqlParameter name)
        {
            string sql = "UPDATE categories " +
                         "SET category_name = @category_name " +
                         "WHERE category_ID = @category_id";
            if (ExecuteDB.Instance.ExecuteNonQuery(sql, id, name) > 0) MessageBox.Show("Update Successfully!");
            else MessageBox.Show("Update Failed!");
        }
    }
}
