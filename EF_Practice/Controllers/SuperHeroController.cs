using Azure.Core;
using EF_Practice.modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<DbClass>>> getDb()
        {

            return Ok(await _context.superheroes.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<DbClass>>> createHero(DbClass addhero)
        {
            _context.superheroes.Add(addhero);
            await _context.SaveChangesAsync();
            return Ok(await _context.superheroes.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<DbClass>>> UpdateHero(DbClass request)
        {
            var Dbhero =await  _context.superheroes.FindAsync(request.Id);
            if (Dbhero == null)
            {
                return BadRequest("Not found");
            }
            Dbhero.Name = request.Name;
            Dbhero.FirstName = request.FirstName;
            Dbhero.LastName = request.LastName;
            Dbhero.Place = request.Place;

            await _context.SaveChangesAsync();
            return Ok(await _context.superheroes.ToListAsync());
        }

        [HttpDelete ("{id}")]
        public async Task<ActionResult<List<DbClass>>> deleteHero(int id)
        {
            var Delhero = await _context.superheroes.FindAsync(id);
            if (Delhero == null)
            {
                return BadRequest("Hero Not found");
            }
            _context.superheroes.Remove(Delhero);
            await _context.SaveChangesAsync();
            return Ok(await _context.superheroes.ToListAsync());
        }
    }
}
