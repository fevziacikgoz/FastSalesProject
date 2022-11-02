using BL.Abstract;
using DAL.Abstract;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class BasketDetailManager : IBasketDetailService
    {
        IBasketDetail _dal;
        IProduct _dal_prod;
        IProductSku _dal_prod_sku;
        IProductSkuPrice _dal_prod_sku_price;
        public BasketDetailManager(IBasketDetail dal, IProduct dal_prod, IProductSku dal_prod_sku, IProductSkuPrice dal_prod_sku_price)
        {
            _dal = dal;
            _dal_prod = dal_prod;
            _dal_prod_sku = dal_prod_sku;
            _dal_prod_sku_price = dal_prod_sku_price;
        }
        public BasketDetail BasketDetailAdd(BasketDetail basketdetail)
        {
            var basketdetailcheck = GetByBasketDetailProduct(basketdetail);
            if (basketdetailcheck != null)
            {
                basketdetailcheck.Quantity += 1;
                var notvatlinetotal = (basketdetailcheck.Quantity * (basketdetailcheck.UnitPrice - ((basketdetailcheck.UnitPrice / 100) * basketdetailcheck.Discount))) / (1 + (basketdetailcheck.TaxRate / 100));
                basketdetailcheck.TaxTotal = (basketdetailcheck.Quantity * (basketdetailcheck.UnitPrice - ((basketdetailcheck.UnitPrice / 100) * basketdetailcheck.Discount))) - notvatlinetotal;
                basketdetailcheck.LineTotal = notvatlinetotal + basketdetailcheck.TaxTotal;
                return _dal.Update(basketdetailcheck);
            }
            else
            {
                var productsku = _dal_prod_sku.GetBy(basketdetail.ProductSkuId);
                var product = _dal_prod.GetBy(Convert.ToInt32(productsku.ProductId));
                var productskprice = GetByProductSkuPrice(basketdetail);
                basketdetail.Quantity = 1;
                basketdetail.UnitPrice = productskprice != null ? Convert.ToDecimal(productskprice.Price) : 0;
                basketdetail.TaxRate = Convert.ToDecimal(product.SalesVat);
                basketdetail.Discount = 0;
                basketdetail.Unit = "Adet";//stokbiriminden çekilecek     
                var notvatlinetotal = (basketdetail.Quantity * (basketdetail.UnitPrice - ((basketdetail.UnitPrice / 100) * basketdetail.Discount))) / (1 + (basketdetail.TaxRate / 100));
                basketdetail.TaxTotal = (basketdetail.Quantity * (basketdetail.UnitPrice - ((basketdetail.UnitPrice / 100) * basketdetail.Discount))) - notvatlinetotal;
                basketdetail.LineTotal = notvatlinetotal + basketdetail.TaxTotal;
                return _dal.Insert(basketdetail);
            }

        }

        public List<BasketDetail> GetBasketDetailList(int basketId)
        {
            return _dal.GetListAll(new string[] { "ProductSku", "ProductSku.ProductSkuImages", "Basket", "Basket.Customer" })
                .Where(w => w.BasketId == basketId).ToList();//firma id ile aktif olan basket getirilmesi gerekiyor
        }

        public BasketDetail GetByBasketDetailProduct(BasketDetail basketdetail)
        {
            return _dal.GetListAll().Where(w => w.BasketId == basketdetail.BasketId && w.ProductSkuId == basketdetail.ProductSkuId).FirstOrDefault();
        }
        public ProductSkuPrice GetByProductSkuPrice(BasketDetail basketdetail)
        {
            return _dal_prod_sku_price.GetListAll().Where(w => w.ProductSkuId == basketdetail.ProductSkuId && w.ProductSkuPriceTypeId == 2).FirstOrDefault();
        }
        public List<Product> GetProductSku(int? categoryId)
        {
            if (categoryId != null && categoryId != 0)
            {
                var data = _dal_prod.GetListAll(new string[] { "ProductSkus", "ProductImages", "ProductSkus.ProductSkuPrices" })

                    .Where(w => w.CategoryId == categoryId).ToList();
                return data;
            }
            else
            {
                var data = _dal_prod.GetListAll(new string[] { "ProductSkus", "ProductImages", "ProductSkus.ProductSkuPrices" })
                                .Where(w => w.GroupCode == 6).ToList();
                return data;
            }

        }

        public List<Product> GetProductSkuWithSearch(string word)
        {
            return _dal_prod.GetListAll(new string[] { "ProductSkus", "ProductImages", "ProductSkus.ProductSkuPrices" })
                   .Where(w => w.ProductSkus.Any(a => a.Title.Contains(word) || a.Barcode.Contains(word) || a.StockCode.Contains(word))).ToList();
        }

        public BasketDetail BasketDetailDelete(BasketDetail basketDetail)
        {
            return _dal.Delete(basketDetail);
        }

        public BasketDetail BasketDetailUpdate(BasketDetail basketdetail)
        {
            var basketdetailcheck = _dal.GetBy(basketdetail.Id);
            if (basketdetailcheck != null)
            {

                basketdetailcheck.Quantity = basketdetail.Quantity != 0 ? basketdetail.Quantity : basketdetailcheck.Quantity;
                basketdetailcheck.UnitPrice = basketdetail.UnitPrice != 0 ? basketdetail.UnitPrice : basketdetailcheck.UnitPrice;
                basketdetailcheck.Discount = basketdetail.Discount != 0 ? basketdetail.Discount : basketdetailcheck.Discount;
                var notvatlinetotal = (basketdetailcheck.Quantity * (basketdetailcheck.UnitPrice - ((basketdetailcheck.UnitPrice / 100) * basketdetailcheck.Discount))) / (1 + (basketdetailcheck.TaxRate / 100));
                basketdetailcheck.Notes = !string.IsNullOrEmpty(basketdetail.Notes) ? basketdetail.Notes : basketdetailcheck.Notes;
                basketdetailcheck.TaxTotal = (basketdetailcheck.Quantity * (basketdetailcheck.UnitPrice - ((basketdetailcheck.UnitPrice / 100) * basketdetailcheck.Discount))) - notvatlinetotal;
                basketdetailcheck.LineTotal = notvatlinetotal + basketdetailcheck.TaxTotal;
            }
            return _dal.Update(basketdetailcheck);

        }

        public BasketDetail GetBasketDetail(BasketDetail basketdetail)
        {
            return _dal.GetListAll(new string[] { "ProductSku", "ProductSku.ProductSkuImages", "Basket", "Basket.Customer" })
                .Where(w => w.Id == basketdetail.Id).FirstOrDefault();
        }

        public BasketDetail DeleteBasketDetail(List<BasketDetail> basketdetail)
        {
            if (basketdetail != null)
            {
                if(basketdetail.Count>0)
                {
                    foreach(var item in basketdetail)
                    {
                        _dal.Delete(item);
                    }
                }
                return null;
            }
            else
                return null;
        }

        public BasketDetail GetById(int id)
        {
            return _dal.GetBy(id);
        }
    }
}
