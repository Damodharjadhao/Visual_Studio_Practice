using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private IConfiguration configuration;
        public SuperHeroController(IConfiguration config)
        {
            configuration = config;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllSuperHeros()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var Heros = await connection.QueryAsync<SuperHero>("SELECT * From superheroes");
            return Ok(Heros);
        }

        [HttpGet("SuperheroID")]
        public async Task<ActionResult<SuperHero>> GetSuperHero(int SuperheroID)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var Hero = await connection.QueryFirstAsync<SuperHero>("SELECT * From superheroes where id=@ID" ,
                new {ID=SuperheroID});
            return Ok(Hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> CreateHero(SuperHero hero)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var add_hero = await connection.ExecuteAsync("Insert into superheroes(Name,FirstName,LastName,place) values(@Name,@FirstName,@LastName,@place)",hero);
            return Ok(add_hero);
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero hero)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var update_hero = await connection.ExecuteAsync("Update superheroes set Name=@Name,FirstName=@FirstName,LastName=@LastName,place=@place where id=@ID", hero);
            return Ok(update_hero);
        }

        [HttpDelete("SuperheroID")]
        public async Task<ActionResult<SuperHero>> DeleteSuperHero(int SuperheroID)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var deleteHero = await connection.ExecuteAsync("delete From superheroes where id=@ID",
                new { ID = SuperheroID });
            return Ok(deleteHero);
        }

    }
}
