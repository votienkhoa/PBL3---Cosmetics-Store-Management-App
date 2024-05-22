using Guna.UI2.WinForms;
using PBL3___Cosmetics_Store_Management_App.DTO;
using PBL3___Cosmetics_Store_Management_App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Presenters
{
    internal class Category_Presenter : SingletonBase<Category_Presenter>
    {
        
        public DataTable ViewCategories()
        {
            return Category_Model.Instance.GetData();
        }

        public DataTable SearchCategory(string txt)
        {
            if (txt == "")
            {
                return Category_Model.Instance.GetData();
            }

            SqlParameter name = new SqlParameter("@nameSearch", "%" + txt + "%");
            SqlParameter id;

            if (int.TryParse(txt, out int x))
            {
                id = new SqlParameter("@idSearch", x);
            }
            else
            {
                id = new SqlParameter("@idSearch", DBNull.Value);
            }
            return Category_Model.Instance.GetData(name, id);
        }

        public void AddOrEditCategory(Category cur, string name)
        {
            if (name != "" && cur == null)
            {
                SqlParameter p = new SqlParameter("@category_name", name);
                Category_Model.Instance.Add(p);
            }

            if (name != "" && cur != null)
            {
                SqlParameter p1 = new SqlParameter("@category_id", cur.ID);
                SqlParameter p2 = new SqlParameter("@category_name", name);

                Category_Model.Instance.Update(p1, p2);
            }
        }

        public void RemoveCategory(Category x)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + x.Name + "\" category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlParameter p = new SqlParameter("@category_id", x.ID);
                Category_Model.Instance.Delete(p);      
            }
        }

        public List<Guna2Button> GetButtonList()
        {
            List<Guna2Button> list = new List<Guna2Button>();
            foreach(Category i in Category_Model.Instance.GetList())
            {
                list.Add(new Guna2Button
                {
                Animated = true,
                BackColor = System.Drawing.Color.Transparent,
                BorderRadius = 10,
                ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,              
                FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82))))),
                Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(3, 3),
                Size = new System.Drawing.Size(173, 50),
                
                Text = i.Name
                });
            }
            return list;
        }
    }
}
