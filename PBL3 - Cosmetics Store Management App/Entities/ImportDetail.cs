using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    public class ImportDetail
    {
        [Key, Column(Order = 0)]
        public string import_id { get; set; }

        [Key, Column(Order = 1)]
        public string product_id { get; set; }
        public int product_quantity { get; set; }
        public DateTime product_MFG { get; set; }
        public DateTime product_EXP { get; set; }

        [ForeignKey("import_id")]
        public virtual Import import { get; set; }

        [ForeignKey("product_id")]
        public virtual Product product { get; set; }
    }
}
