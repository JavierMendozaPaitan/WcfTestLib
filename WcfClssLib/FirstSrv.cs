using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClssLib
{
    public class FirstSrv : IFirstSrv
    {
        public string GetMessage(string txt)
        {
            return "This is the First WCF Service.";
        }
    }
}
