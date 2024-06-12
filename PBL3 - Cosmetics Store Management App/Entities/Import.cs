using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("imports")]
    public class Import
    {
        public Import()
        {
            importdetails = new HashSet<ImportDetail>();
        }
        [Key]
        [Required]
        public string import_id {  get; set; }
        public int provider_id { get; set; }
        public DateTime import_date { get; set; }
        public string staff_id { get; set; }
        public virtual ICollection<ImportDetail> importdetails { get; set;}

        [ForeignKey("staff_id")]
        public virtual Staff staff { get; set; }
        [ForeignKey("provider_id")]
        public virtual Provider provider { get; set; }
    }
}
