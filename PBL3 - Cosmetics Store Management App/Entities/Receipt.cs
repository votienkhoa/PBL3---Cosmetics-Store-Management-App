using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("receipts")]
    public class Receipt
    {
        public Receipt()
        {
            receiptdetails = new HashSet<ReceiptDetail>();
        }
        [Key]
        public string receipt_id {  get; set; }
        public DateTime receipt_date { get; set; }
        public double receipt_total { get; set; }
        public double receipt_discount { get; set; }
        public string staff_id { get; set; }
        public virtual ICollection<ReceiptDetail> receiptdetails { get; set; }
        [ForeignKey("staff_id")]
        public virtual Staff staff { get; set; }
    }
}
