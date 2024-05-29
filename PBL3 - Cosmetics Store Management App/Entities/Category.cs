using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("categories")]
    public class Category
    {
        public Category()
        {
            products = new HashSet<Product>();
        }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int category_id { get; set; }
        public string category_name { get; set; }

        public virtual ICollection<Product> products { get; set; }

        
    }
}
