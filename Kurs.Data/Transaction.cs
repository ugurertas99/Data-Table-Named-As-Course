using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Data
{
    public class Transaction:Stock
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]  
        public DateTime EntryDate { get; set; }
        [Required]  
        public DateTime ReleasedDate { get; set; }

    }
}
