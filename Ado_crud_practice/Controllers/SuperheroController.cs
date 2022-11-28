using Ado_crud_practice.Model;
using Ado_crud_practice.Repositorys;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ado_crud_practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroController : ControllerBase
    {
        private IConfiguration _configuration;

        private SuperHeroRepo herpReopo;

        public SuperheroController(IConfiguration configuration)
        {
            _configuration = configuration;
            herpReopo = new SuperHeroRepo(configuration);
        }

        // GET: api/<SuperheroController>
        [HttpGet]
        public IActionResult Getdata()
        {
            return Ok(herpReopo.get());
        }

        [HttpPost]
        public IActionResult PostData(SuperHero hero1)
        {
            return Ok(herpReopo.Post(hero1));
        }

        [HttpPut]
        public IActionResult UpdateData(SuperHero updatehero, int id)
        {
            return Ok(herpReopo.Update(updatehero, id));
        }

        [HttpDelete]
        public IActionResult DeleteData(int id)
        {
            return Ok(herpReopo.Delete(id));
        }
    }
}
