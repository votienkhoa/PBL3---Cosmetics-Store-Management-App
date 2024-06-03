using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Required]
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual ICollection<Receipt> receipts { get;}

    }
}
