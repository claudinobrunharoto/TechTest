using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddPassengersToVehicleController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult AddPassengersToVehicle(int number)
        {
            try
            {
                new Car().Start(Person.CreateList(number));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToCar(int number)
        {
            try
            {
                new Car().Start(Person.CreateList(number));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToMotorBike(int number)
        {
            try
            {
                new MotorBike().Start(Person.CreateList(number));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToCoach(int number)
        {
            try
            {
                new Coach().Start(Person.CreateList(number));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
