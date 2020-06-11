using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductDemoApp.Models;
using ProductDemoApp.Service;

namespace ProductDemoApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductsRepository productService;

        public ProductController(ILogger<ProductController> logger, IProductsRepository productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var flag = false;
            if (ModelState.IsValid)
            {
                if (product != null)
                {
                    flag= productService.AddProduct(product);
                }
                if (flag)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult ProductsList()
        {
            IList<Product> list = productService.GetAllProducts();
            return View(list);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult IsGreatrThanToday(DateTime ExpiryDate)
        {
            if (ExpiryDate > DateTime.Today)
            {
                return Json(true);
            }
            else
            {
                return Json("Expiry Date must be greater than Today's Date.");
            }
        }
    }
}
