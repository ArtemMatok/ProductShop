using Microsoft.AspNetCore.Mvc;
using ProductShop.Interfaces;
using ProductShop.Models;

namespace ProductShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
           _productRepository = productRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _productRepository.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Product product = await _productRepository.GetByIdAsync(id);
            return View(product);
        }
    }
}
