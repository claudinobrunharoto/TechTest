using Domain.Interface;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dto;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddPassengersToVehicleController : ControllerBase
    {
        private readonly IVehicleFactory vehicleFactory;

        public AddPassengersToVehicleController(IVehicleFactory vehicleFactory)
        {
            this.vehicleFactory = vehicleFactory;
        }

        [HttpPost]
        public IActionResult AddPassengersToVehicle([FromBody] AddPassengerToVehicleDto addPassengerToVehicleDto)
        {
            try
            {
                var vehicle = this.vehicleFactory.CreateVehicle(addPassengerToVehicleDto.VehicleType);
                vehicle.AddPassengers(Person.CreateList(addPassengerToVehicleDto.Quantity));
                vehicle.Start();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
