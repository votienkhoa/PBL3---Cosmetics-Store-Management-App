using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    public class Provider
    {
        public Provider()
        {
            imports = new HashSet<Import>();
        }

        [Key]
        [Required]
        public string provider_id { get; set; }
        public string provider_name { get; set; }
        public ICollection<Import> imports { get; set; }
    }
}
