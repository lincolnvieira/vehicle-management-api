namespace Domain.Models
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }
}