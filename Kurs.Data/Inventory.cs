using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Data
{
    public class Inventory:Stock
    {
        [Key]
        public int InventoryId { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public double BuyingPrice { get; set; }

        public int Discount { get; set; }

        public int Tax { get; set; }

        public int RemainingQuantity { get; set; }

        

    }
}
