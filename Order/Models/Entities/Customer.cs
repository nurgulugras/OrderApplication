namespace Order.Models.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public Address Address { get; set; }
    }
}