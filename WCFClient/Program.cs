using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo.ProductInfoClient proxy = new ProductInfo.ProductInfoClient();
            Console.WriteLine("Price: {0}", proxy.GetProduct(2));
        }
    }
}
