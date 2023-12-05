using Application.Repositories.ProductFold;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LastVersionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductController(IProductWriteRepository productWriteRepository , IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;

        }


        [HttpGet]
        public  async void Get()
        {
             await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = 1 , LastModify=DateTime.UtcNow , Name="prod1" , Stock=10, Price=100 },
                new() { Id = 13 , LastModify=DateTime.UtcNow , Name="prod2" , Stock=20, Price=200 },
                new() { Id = 23 , LastModify=DateTime.UtcNow , Name="prod3" , Stock=30, Price=300 },
            });
            await  _productWriteRepository.SaveAsync();
        }
    }
}
