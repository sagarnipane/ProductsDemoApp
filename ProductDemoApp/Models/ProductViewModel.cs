using Microsoft.AspNetCore.Mvc;
using ProductDemoApp.Attributes;
using ProductDemoApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDemoApp.Models
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "Please enter product name.")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter price.")]
        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter quantity.")]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Is GST Applicable")]
        public bool IsGSTApplicable { get; set; }

        [Required(ErrorMessage = "Please select purchase date.")]
        [DataType(DataType.Date)]
        [DisplayName("Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Please select expiry date.")]
        [DataType(DataType.Date)]
        [DisplayName("Expiry Date")]
        //[CustomExpiryDate(ErrorMessage = "Expiry Date must be greater than Today's Date.")]
        [Remote(action: "IsGreatrThanToday", controller: "Product")]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage ="Please select product color.")]
        [DisplayName("Color")]
        public Color Color { get; set; } //Color type as Enum
    }
}
