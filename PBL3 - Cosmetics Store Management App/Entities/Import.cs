using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    public class Import
    {
        public Import()
        {
            importdetails = new HashSet<ImportDetail>();
        }
        [Key]
        [Required]
        public string import_id {  get; set; }
        public string import_provider { get; set; }
        public DateTime import_date { get; set; }
        public string staff_id { get; set; }
        public virtual ICollection<ImportDetail> importdetails { get; set;}

        [ForeignKey("staff_id")]
        public virtual Staff staff { get; set; }
    }
}
