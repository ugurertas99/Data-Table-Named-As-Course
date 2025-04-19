using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Data
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        [Required]
        public int Quantity { get; set; }

        public string Unit { get; set; }

        [Required]
        public string StockCode { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime RegisterDate { get; set; }

    }
}
