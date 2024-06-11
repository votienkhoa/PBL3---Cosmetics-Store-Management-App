using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("customer")]
    public class Customer
    {
        public Customer()
        {
            receipts = new HashSet<Receipt>();
        }
        [Key]
        [Required]
        public string customer_phone { get; set; }

        public string customer_name { get; set; }
        public virtual ICollection<Receipt> receipts { get;}

    }
}
