using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfClssLib
{
    [ServiceContract]
    public interface IFirstSrv
    {
        [OperationContract]
        string GetMessage(string txt);
    }
}
