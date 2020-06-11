using ProductDemoApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDemoApp.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public bool IsGSTApplicable { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public Color Color { get; set; }  //Color type as Enum
    }
}
