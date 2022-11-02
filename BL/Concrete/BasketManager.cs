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
    public class BasketManager : IBasketService
    {
        IBasket _dal;
        public BasketManager(IBasket dal)
        {
            _dal = dal;
        }

        public Basket BasketAdd(Basket basket)
        {
            basket.CustomerId = 2;//firmada tanımlı varsayılan cari ünvanı gelecek
            basket.CompanyGroupId = 1;//kullanıcıda tanımlı companygroupid gelecek
            basket.CompanyId = 4;
            return _dal.Insert(basket);
        }
        public List<Basket> GetBasketList(bool boolcheck)
        {
            if (boolcheck)
                return _dal.GetListAll(new string[] { "Customer" }).Where(w => w.CompanyId == 4 && w.Status == true).ToList();
            else
                return _dal.GetListAll(new string[] { "Customer" }).Where(w => w.CompanyId == 4 && w.Status == false).ToList();
        }
        public Basket GetBasket(int basketId)
        {
            return _dal.GetBy(basketId);//companyId ile filtrelenip gelmelidir yada ilgili fonksiyon companyid değerine göre 
        }

        public Basket UpdateBasket(List<BasketDetail> basketdetail = null, Basket basket = null)
        {
            //if (basketdetail != null)
            //{
            //    if (basketdetail.Count > 0)
            //    {
            //        var _basket = GetBasket(basketdetail[0].BasketId);
            //        if (_basket != null)
            //        {
            //            _basket.InvoicTaxTotal = basketdetail.Sum(s => s.TaxTotal);
            //            _basket.InvoiceTotal = basketdetail.Sum(s => s.LineTotal) - basketdetail.Sum(s => s.TaxTotal);
            //            _basket.InvoicTaxTotal = _basket.Discount == 0 ? _basket.InvoicTaxTotal : (_basket.DiscountType == 1 ? _basket.InvoicTaxTotal - ((_basket.InvoicTaxTotal / 100) * _basket.Discount) : _basket.InvoicTaxTotal - (_basket.Discount / 2));
            //            _basket.InvoiceTotal = _basket.Discount == 0 ? _basket.InvoiceTotal : (_basket.DiscountType == 1 ? _basket.InvoiceTotal - ((_basket.InvoiceTotal / 100) * _basket.Discount) : _basket.InvoiceTotal - (_basket.Discount / 2));

            //            _dal.Update(_basket);
            //        }
            //    }
            //}
            if (basket != null)
            {
                basket.InvoicTaxTotal = basketdetail != null ? basketdetail.Sum(s => s.TaxTotal) : 0;
                basket.InvoiceTotal = basketdetail != null ? basketdetail.Sum(s => s.LineTotal) - basketdetail.Sum(s => s.TaxTotal) : 0;
                basket.InvoicTaxTotal = basket.Discount == 0 ? basket.InvoicTaxTotal : (basket.DiscountType == 1 ? basket.InvoicTaxTotal - ((basket.InvoicTaxTotal / 100) * basket.Discount) : basket.InvoicTaxTotal - (basket.Discount / 2));
                basket.InvoiceTotal = basket.Discount == 0 ? basket.InvoiceTotal : (basket.DiscountType == 1 ? basket.InvoiceTotal - ((basket.InvoiceTotal / 100) * basket.Discount) : basket.InvoiceTotal - (basket.Discount / 2));
                return _dal.Update(basket);
            }
            return null;



        }

        public Basket ChangeBasket(Basket basketdeactive, Basket basketactive)
        {
            if (basketactive != null)
            {
                basketactive.Status = false;
                _dal.Update(basketactive);
            }
            basketdeactive.Status = true;
            return _dal.Update(basketdeactive);
        }

        public Basket DeleteBasket(Basket basket)
        {
            return _dal.Delete(basket);
        }
    }
}

