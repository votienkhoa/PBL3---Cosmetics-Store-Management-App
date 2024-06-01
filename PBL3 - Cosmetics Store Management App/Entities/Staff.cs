using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    [Table("staffs")]
    public class Staff
    {
        [Key]
        [Required]
        public string staff_id { get; set; }
        public string staff_name { get; set;}
        public string staff_PhoneNumber { get; set;}
        public  DateTime staff_birthday { get; set; }
        public string staff_address { get; set; }
        public string staff_password { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int staff_role { get; set; }

    }
}
