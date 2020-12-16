﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfTestLib
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Sustract(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
        [OperationContract]
        double Divide(double n1, double n2);
    }
}
