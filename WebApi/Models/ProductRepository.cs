using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ProductRepository : IProduct
    {
        private List<Product> listProducts = new List<Product>();
        public ProductRepository()
        {
            listProducts.Add(new Product { ID = "p1", Name = "aaaa", Price = 100 });
            listProducts.Add(new Product { ID = "p2", Name = "bbbb", Price = 200 });
        }
        public Product FindbyId(string id)
        {
            return listProducts.Single(p =>p.ID.Equals(id));
        }

        public IEnumerable<Product> GetAll()
        {
            return listProducts;
        }
    }
}