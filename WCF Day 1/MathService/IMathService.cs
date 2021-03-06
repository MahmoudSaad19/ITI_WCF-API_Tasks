﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathService
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        double Add(double x, double y);

        [OperationContract]
        double Subtract(double x, double y);

        [OperationContract]
        double Multiply(double x, double y);
        
        [OperationContract]
        double Divide(double x, double y);


    }
}
