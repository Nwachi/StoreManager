using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreManager.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public Product Product { get; set; }
        [Display(Name ="Quantity Sold"),Required]
        public int QuantitySold { get; set; }
        [Display(Name = "Date Sold"), Required]
        public DateTime DateSold { get; set; }
        [Required]
        public double Price { get; set; }

    }
}