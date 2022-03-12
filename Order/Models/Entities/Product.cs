using System.ComponentModel.DataAnnotations;

namespace Order.Models.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Name { get; set; }
    }
}