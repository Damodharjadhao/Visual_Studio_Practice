using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { 
                Calculator_Library.Class1.Add(30,20),
                Calculator_Library.Class1.Sub(30,20),
                Calculator_Library.Class1.Multi(30,10),
                Calculator_Library.Class1.Div(30,5)
            };
        }
    }
}
