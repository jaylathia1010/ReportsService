using Microsoft.AspNetCore.Mvc;

namespace ReportsService.Controllers
{
    [ApiController]
    [Route("api/Reports/[controller]")]
    public class PizzaDetailController : ControllerBase
    {
        public PizzaDetailController()
        {
            
        }

        [HttpPost]
        public ActionResult<string> TestInBoundConnection()
        {
            Console.WriteLine("---> InBound Connection Made to Reports..!");

            return Created("api/reports/pizza", "InBound connection to Reports is successful..!");
        }
    }
}