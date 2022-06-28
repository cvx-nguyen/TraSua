using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraSua.Shared;

namespace TraSua.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraSuaController : ControllerBase
    {
        private static readonly List<Product> products = new List<Product>
        {          new Product(1, "\nNhiều trân châu", 12.00M, Pearl.nhieu),
                   new Product(2, "\nÍt trân châu", 10.00M, Pearl.it),
                   new Product(3, "\nKhông trân châu", 9.99M, Pearl.None)
        };
        [HttpGet("/trasua")]
        public IQueryable<Product> GetProducts()
            => products.AsQueryable();
    }
}
