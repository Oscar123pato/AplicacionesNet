using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using CatalogServiceQueries;
using CatalogServiceQueries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;

namespace Catalog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductQueryService _productQueryService;
        private readonly IMediator _mediator;

        public ProductController(ApplicationDbContext context, IProductQueryService productQueryService, IMediator mediator)
        {
            _context = context;
            _productQueryService = productQueryService;
           _mediator = mediator;
        }

        //product

        [HttpGet]
        public async Task<DataCollection<ProductDto>> GetAll(int page = 1, int take = 30, string ids = null)
        {
            IEnumerable<int>? products = null;
            if (!string.IsNullOrEmpty(ids))
            {
                //products = ids.Split(',').Select(x => Convert.ToInt32(x));
            }
            return await _productQueryService.GetAllAsync(page, take, products);
        }

        //product/id

        [HttpGet("{id}")]
        public async Task<ProductDto> Get(int id)
        {
            return await _productQueryService.GetAsync(id);
        }


        [HttpPost]
        public async Task<ActionResult<Unit>> Create(ProductCreateCommand command)
        {
             //await _mediator.Publish(command);

            //return Ok();
            return await _mediator.Send(command);
        }
    }
}
