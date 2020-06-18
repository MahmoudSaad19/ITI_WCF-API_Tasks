using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CRUD_Service
{
    public class ProductService : IProductService
    {
        ProductContext dbContext;

        public ProductService()
        {
            dbContext = new ProductContext();
        }
        public bool AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            return dbContext.SaveChanges() > 0;
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
