using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreAPI.Models
{
    public class cPart
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        public string ProductCategory{ get; set; }

        [Required]
        public decimal ProductQuantity { get; set; }

    }
}
