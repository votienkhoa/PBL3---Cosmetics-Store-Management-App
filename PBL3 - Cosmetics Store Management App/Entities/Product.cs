using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("products")]
    public class Product
    {
        [Key]
        public string product_id { get; set; }
        public string product_name { get; set;}
        public string product_unit { get; set;}
        public string product_origin { get; set;}
        public double product_price { get; set;}
        public byte[] product_image { get; set;}
        public int category_id { get; set;}

        [ForeignKey("category_id")]
        public virtual Category category { get; set; }

    }
}
