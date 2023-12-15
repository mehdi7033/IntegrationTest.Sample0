using Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [Route("/customers")]
        public ActionResult<Customer> Get()
        {
            var person = new Customer()
            {
                Id = 1,
                Name="Ali"
            };

            return person;
        }
    }
}
