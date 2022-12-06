using Dapper;
using Dapper_Crud.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Dapper_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private IConfiguration configuration;
        private ISqlQueryProvider _queryProvider;
        public SuperHeroController(IConfiguration config,ISqlQueryProvider queryProvider)
        {
            configuration = config;
            _queryProvider = queryProvider;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllSuperHeros()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var Heros = await connection.QueryAsync<SuperHero>(_queryProvider.GetAllDataQuery());
            return Ok(Heros);
        }

        [HttpGet("GetAllDataByStoredProcedure")]
        public async Task<ActionResult<List<SuperHero>>> GetAllDataByStoredProcedure()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var Heros = await connection.QueryAsync("GetAllData");
            return Ok(Heros);
        }

        [HttpGet("SuperheroID")]
        public async Task<ActionResult<SuperHero>> GetSuperHero(int SuperheroID)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var Hero = await connection.QueryFirstAsync<SuperHero>(_queryProvider.GetDataById(SuperheroID));
            return Ok(Hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> CreateHero(SuperHero hero)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var add_hero = await connection.ExecuteAsync(_queryProvider.CreateData(hero));
            return Ok(add_hero);
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero hero)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var update_hero = await connection.ExecuteAsync(_queryProvider.UpdateDataQuery(hero));
            return Ok(update_hero);
        }

        [HttpDelete("SuperheroID")]
        public async Task<ActionResult<SuperHero>> DeleteSuperHero(int SuperheroID)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            var deleteHero = await connection.ExecuteAsync(_queryProvider.DeleteDataQuery(SuperheroID));
            return Ok(deleteHero);
        }

    }
}
