﻿using System;
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
        List<Product>
    }
}
