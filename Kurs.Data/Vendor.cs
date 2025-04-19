using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Data
{
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }
        [Required]
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
