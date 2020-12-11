using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContosoPets.Models
{
    public class Product
    {
        //speical indetifier idicates that property is reated as the  Primary key which can be marked with   [Key] to indictae primary
        [Key]
        public int Id { get; set; }

        // Required means it cannot be null
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
