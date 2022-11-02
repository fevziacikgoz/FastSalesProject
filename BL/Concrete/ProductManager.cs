using BL.Abstract;
using DAL.Abstract;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class ProductManager : IProductSkuService
    {
        IProductSku _dal;
        public ProductManager(IProductSku dal)
        {
            _dal = dal;
        }

        public List<ProductSku> GetProductSkuList(int productId)
        {
            return _dal.GetListAll(new string[] { "Product", "ProductSkuImages", "ProductSkuPrices" }).Where(w => w.ProductId == productId).ToList();
        }
    }
}
