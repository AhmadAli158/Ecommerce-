using Microsoft.AspNetCore.Mvc;
using Ecommerce_app.Data;

namespace Ecommerce_app.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly Datadbcontext _dbContext;

		public ProductController(Datadbcontext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpGet]
		public IActionResult GetProducts()
		{
			var products = _dbContext.products;
			return Ok(products);
		}

		[HttpPost]
		public IActionResult CreateProduct([FromBody] product product)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_dbContext.products.Add(product);
			_dbContext.SaveChanges();

			return CreatedAtAction(nameof(GetProducts), new { id = product.Product_id }, product);
		}
	}
}