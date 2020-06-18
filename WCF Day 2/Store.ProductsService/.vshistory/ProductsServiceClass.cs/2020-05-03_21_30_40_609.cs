using System;
using System.Collections.Generic;
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
            dbContext.Products.A
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
