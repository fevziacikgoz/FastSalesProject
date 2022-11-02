using DAL.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IBasketService
    {
        Basket BasketAdd(Basket basket);
        List<Basket> GetBasketList(bool boolcheck);
        Basket GetBasket(int basketId);
        Basket UpdateBasket(List<BasketDetail> basketdetail = null, Basket basket = null);
        Basket ChangeBasket(Basket basketdeactive, Basket basketactive);
        Basket DeleteBasket(Basket basket);
    }
}
