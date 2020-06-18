using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DB_CRUD_Service
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        bool AddProduct(Product product);

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        bool EditProduct(Product product);

        [OperationContract]
        bool DeleteProduct(int id);

    }
}
