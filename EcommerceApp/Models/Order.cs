﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
