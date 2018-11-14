using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreManager.Models
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public Sale Sale { get; set; }
        [Display(Name ="Sale Id")]
        public int SaleId { get; set; }
        public int ProductQuantity { get; set; }
    }
}