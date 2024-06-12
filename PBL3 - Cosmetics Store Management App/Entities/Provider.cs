using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("providers")]
    public class Provider
    {
        public Provider()
        {
            imports = new HashSet<Import>();
        }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int provider_id { get; set; }
        public string provider_name { get; set; }
        public ICollection<Import> imports { get; set; }
    }
}
