using Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        [HttpGet]
        [Route("/persons")]
        public IActionResult GetPeople()
        {
            return Ok(Data.GetPeople());
        }
    }
}
