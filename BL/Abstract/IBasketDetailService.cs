using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IBasketDetailService
    {
        BasketDetail BasketDetailAdd(BasketDetail basketdetail);
        List<BasketDetail> GetBasketDetailList(int basketId);
        List<Product> GetProductSku(int? categoryId);
        List<Product> GetProductSkuWithSearch(string word);
        BasketDetail GetByBasketDetailProduct(BasketDetail basketdetail);
        BasketDetail BasketDetailDelete(BasketDetail basketDetail);
        BasketDetail BasketDetailUpdate(BasketDetail basketdetail);
        BasketDetail DeleteBasketDetail(List<BasketDetail> basketdetail);
        BasketDetail GetById(int id);
        
    }
}
