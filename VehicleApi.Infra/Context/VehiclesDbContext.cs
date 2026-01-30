using Microsoft.EntityFrameworkCore;
using VehicleApi.Domain.Entities;

namespace VehicleApi.Infra.Context {
    public class VehiclesDbContext : DbContext {
        public VehiclesDbContext(DbContextOptions<VehiclesDbContext> options) : base(options) {
        }

        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    }
}