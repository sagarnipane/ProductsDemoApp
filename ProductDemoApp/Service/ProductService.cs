using Newtonsoft.Json;
using ProductDemoApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace ProductDemoApp.Service
{
    public class ProductService :IProductsRepository
    {
        private readonly string path; 
        string JSON=null;
        List<Product> products;
        public ProductService()
        {
            products = new List<Product>(); 
            //When the first time service is invoked Existing data from JSON file is retrieved
            path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"Data\\Products.json"}");
            JSON = System.IO.File.ReadAllText(path);
            products= JsonConvert.DeserializeObject<List<Product>>(JSON);
        }
            
        public bool AddProduct(Product product)
        {
            if(product != null)
            {
                this.products.Add(product);
                return true;
            }
            return false;
        }
        public List<Product> GetAllProducts()
        {
            return this.products;
        }
         
    }
}
