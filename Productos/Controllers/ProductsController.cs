using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Productos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Guitarra Eléctrica", Price = 800, Description = "Cuerdas metálicas" },
            new Product { Id = 2, Name = "Batería", Price = 500, Description = "Yamamha Edge" }
        };

        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return products.Single(x => x.Id == id);
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            model.Id = products.Count + 1;
            products.Add(model);

            return CreatedAtAction(
                "Get",
                new { id = model.Id },
                model
                );
        }
        [HttpPut("{productId}")]
        public ActionResult Update(int productId, Product model)
        {
            var productEntry = products.Single(x => x.Id == productId);
            productEntry.Id = model.Id;
            productEntry.Name = model.Name;
            productEntry.Price = model.Price;
            productEntry.Description = model.Description;

            return NoContent();
        }
        [HttpDelete("{productId}")]
        public ActionResult Delete(int productId)
        {
            products = products.Where(x => x.Id != productId).ToList();

            return NoContent();
        }


    }
}
