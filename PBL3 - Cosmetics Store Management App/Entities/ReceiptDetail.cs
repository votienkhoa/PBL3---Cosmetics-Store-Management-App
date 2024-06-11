using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("receiptdetails")]
    public class ReceiptDetail
    {
        [Key, Column(Order = 0)]
        public string receipt_id { get; set; }

        [Key, Column(Order = 1)]
        public string product_id { get; set; }

        public int product_quantity { get; set; }

        [ForeignKey("receipt_id")]
        public virtual Receipt receipt { get; set; }

        [ForeignKey("product_id")]
        public virtual Product product { get; set; }

    }
}
