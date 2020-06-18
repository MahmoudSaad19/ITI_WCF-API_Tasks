using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Store.ProductsRepo;

namespace Store.ProductsService
{
    [ServiceContract]
    public interface IProductsService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        bool DeleteProduct(int id);

        [OperationContract]
        bool AddProduct(Product product);

        [OperationContract]
        bool EditProduct(Product product);

    }
}
