using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var product = dbContext.Products.Find(id);
            dbContext.Products.Remove(product);
            return dbContext.SaveChanges() > 0;
        }

        public bool EditProduct(Product product)
        {
            dbContext.Entry(product).State = EntityState.Modified;
            return dbContext.SaveChanges() > 0;
        }

        public Product GetProduct(int id)
        {
            return dbContext.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }
    }
}
