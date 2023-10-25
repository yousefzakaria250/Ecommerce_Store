using Ecommece.Infrastructure.Data;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController :ControllerBase
    {
        private readonly IProductRepo productRepo;
        public ProductsController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            //var result = store.Products.ToList();
            var result = await productRepo.GetAllProducts(); 
            return Ok(result);
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetSingleProduct( int Id)
        {
            // var result = store.Products.FirstOrDefault(p => p.Id == Id);
            // var result = store.Products.Find(Id);
            var result = await productRepo.GetProduct(Id);
            return Ok(result);  
        }



    }
}
