using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Entities;
using WebApplicationAPI.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private IAppDbContext _appDbContext;


        public CategoriasController(IAppDbContext context)
        {
            _appDbContext = context;
        }
        // GET: api/<CategoriasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CategoriasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public async Task<Categorias> Post(Categorias categorias)
        {
            _appDbContext.Categorias.Add(categorias);
            await _appDbContext.SaveChangesAsync();
            return categorias;

        }

        // PUT api/<CategoriasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
