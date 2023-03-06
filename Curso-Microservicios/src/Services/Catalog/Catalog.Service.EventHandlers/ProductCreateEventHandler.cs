using Catalog.Domain;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductCreateEventHandler : IRequestHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductCreateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(ProductCreateCommand command, CancellationToken cancellation)
        {
            var product = new Product
            // await _context.AddAsync(new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price
            };
            //);
            _context.Products.Add(product);
            var valor = await _context.SaveChangesAsync();
            if (valor > 0)
            {
                return Unit.Value;
            }
            throw new Exception("No se puede insertar el Autor del libro");
        }
    }
}
