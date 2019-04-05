using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFApp.DAL;

namespace WCFApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductInfo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductInfo.svc or ProductInfo.svc.cs at the Solution Explorer and start debugging.
    public class ProductInfo : IProductInfo
    {
        public void DoWork()
        {
        }

        public decimal GetPrice(int productId)
        {
            DemoDBModel context = new DemoDBModel();
            var product = context.Products.Find(productId);
            if (product == null)
            {
                throw new ArgumentOutOfRangeException("productId");
            }
            return product.Price;
        }

        public Product GetProduct(int productId)
        {
            DemoDBModel context = new DemoDBModel();
            var product = context.Products.Find(productId);
            if (product == null)
            {
                throw new ArgumentOutOfRangeException("productId");
            }
            return new Product { Id = product.Id, Name = product.Name, Price = product.Price };
        }
    }
}
