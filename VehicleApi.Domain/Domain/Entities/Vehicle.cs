using VehicleApi.Domain.Enums;

namespace VehicleApi.Domain.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }

        public string? Optional { get; set; }
        public decimal? Price { get; set; }
    }
}
