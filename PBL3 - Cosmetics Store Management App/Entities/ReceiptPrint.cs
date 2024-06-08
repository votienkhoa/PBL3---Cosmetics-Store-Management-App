using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Entities
{
    public class ReceiptPrint
    {
        public int number {  get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double amount { get; set; }
    }
}
