using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTestLib
{
    public class CalcSrv : ICalculator
    {
        public double Add(double n1, double n2)
        {
            try
            {
                var rst = n1 + n2;
                return rst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double Divide(double n1, double n2)
        {
            try
            {
                var rst = n1 / n2;
                return rst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double Multiply(double n1, double n2)
        {
            try
            {
                var rst = n1 * n2;
                return rst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double Sustract(double n1, double n2)
        {
            try
            {
                var rst = n1 - n2;
                return rst;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
