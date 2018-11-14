using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreManager.Models
{
    public class Product
    {
       public int Id { get; set; }
        [Display(Name = "Product Name"), Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Display(Name = "Expiration Date"), Required]
        public DateTime DateTime { get; set; }
        [Required]
        public double Price { get; set; }

    }
}