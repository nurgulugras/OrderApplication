using System;
using System.ComponentModel.DataAnnotations;

namespace Order.Models.Entities
{
    public class Orders:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}