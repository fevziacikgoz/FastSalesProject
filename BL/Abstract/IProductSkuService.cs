using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IProductSkuService
    {
        List<ProductSku> GetProductSkuList(int productId);
    }
}
