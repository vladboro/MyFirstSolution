using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductInfo" in both code and config file together.
    [ServiceContract]
    public interface IProductInfo
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        decimal GetPrice(int productId);
        [OperationContract]
        DAL.Product GetProduct(int productId);    }
}
