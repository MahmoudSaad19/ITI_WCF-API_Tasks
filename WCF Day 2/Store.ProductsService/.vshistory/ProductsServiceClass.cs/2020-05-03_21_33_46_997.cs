using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.ProductsRepo;

namespace Store.ProductsService
{
    public class ProductsService : IProductsService
    {
        StoreContext dbContext = new StoreContext();

        public bool AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            return dbContext.SaveChanges() > 0;
        }

        public bool DeleteProduct(int id)
        {
            dbContext.Products.Remove(dbContext.Products.Find(id));
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
