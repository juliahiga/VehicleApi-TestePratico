using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleApi.Domain.Entities;
using VehicleApi.Infra.Context;

namespace VehicleApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly VehiclesDbContext _context;

        public VehicleController(VehiclesDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Vehicle vehicle)
        {
            vehicle.Id = Guid.NewGuid();

            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = vehicle.Id }, vehicle);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Vehicle vehicle)
        {
            var existente = await _context.Vehicles.FindAsync(id);
            if (existente == null)
                return NotFound();

            existente.Description = vehicle.Description;
            existente.Brand = vehicle.Brand;
            existente.Model = vehicle.Model;
            existente.Optional = vehicle.Optional;
            existente.Price = vehicle.Price;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            return vehicle == null ? NotFound() : Ok(vehicle);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
                return NotFound();

            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}