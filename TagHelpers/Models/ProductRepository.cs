using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Samsung s7",Price=300},
            new Product(){ProductId=2,ProductName="Samsung s8",Price=400},
            new Product(){ProductId=3,ProductName="Samsung s9",Price=500},
            new Product(){ProductId=4,ProductName="Samsung s10",Price=600},
            new Product(){ProductId=5,ProductName="Samsung s11",Price=700},
            new Product(){ProductId=6,ProductName="Samsung s12",Price=800}
        };

        public IEnumerable<Product> Products => _products;

        public void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}
