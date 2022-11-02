using BL.Abstract;
using DAL.Abstract;
using DAL.Entity;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class ReturnOrderManager : IReturnOrderService
    {

        IReturnOrder _dal;
        IReturnOrderDetail _detail;
        public ReturnOrderManager(IReturnOrder dal, IReturnOrderDetail detail)
        {
            _dal = dal;
            _detail = detail;
        }

        public ReturnOrder AddOrder(ReturnOrder order)
        {
            order.CompanyId = 4;//öndeğerden gelecek
            order.CompanyGroupId = 1;//öndeğerden gelecek
            order.StoreId = 0;
            order.OrderDate = DateTime.Now;
            order.OrderStatusId = 4;
            order.MarketPlaceId = 0;
            order.MarketPlaceStoreId = "0";
            order.MarketPlaceOrderId = "0";
            order.EInvoiceId = 0;
            order.EArchiveId = 0;
            order.EDocumentNumber = "0";
            order.Ettn = "0";
            return _dal.Insert(order);
        }

        public ReturnOrderDetail AddOrderDetail(ReturnOrderDetail orderDetail)
        {
            return _detail.Insert(orderDetail);
        }

        public ReturnOrder GetReturnOrder(int id)
        {
            return _dal.GetBy(id);
        }

        public List<ReturnOrderDetail> GetReturnOrderDetailList(int? returnorderId)
        {
            return _detail.GetListAll(new string[] { "ProductSkus", "ProductSkus.ProductSkuImages", "ReturnOrder", "ReturnOrder.Customer" })
              .Where(w => w.OrderId == returnorderId).ToList();//firma id ile aktif olan basket getirilmesi gerekiyor
        }
        public ReturnOrder UpdateReturnOrder(ReturnOrder returnOrder)
        {
            return _dal.Update(returnOrder);
        }
    }
}
