using ProductDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDemoApp.Service
{
    public interface IProductsRepository
    {
        List<Product> GetAllProducts();
        bool AddProduct(Product product);
    }
}
