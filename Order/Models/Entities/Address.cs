using System.ComponentModel.DataAnnotations;

namespace Order.Models.Entities
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        [Required]
        public string AddressLine { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int CityCode { get; set; }
    }
}