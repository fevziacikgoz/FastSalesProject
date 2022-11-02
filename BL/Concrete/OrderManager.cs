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
    public class OrderManager : IOrderService
    {

        IOrder _dal;
        IOrderDetail _detail;
        public OrderManager(IOrder dal, IOrderDetail detail)
        {
            _dal = dal;
            _detail = detail;
        }

        public Order AddOrder(Order order)
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

        public OrderDetail AddOrderDetail(OrderDetail orderDetail)
        {
            return _detail.Insert(orderDetail);
        }

        public Order GetOrder(int orderId)
        {
            return _dal.GetBy(orderId);
        }

        public OrderDetail GetOrderDetail(int orderDetailId)
        {
            return _detail.GetBy(orderDetailId);
        }

        public List<OrderDetail> GetOrderDetailList(int? orderId)
        {
            return _detail.GetListAll(new string[] { "ProductSkus", "ProductSkus.ProductSkuImages", "Order", "Order.Customer" })
              .Where(w => w.OrderId == orderId).ToList();//firma id ile aktif olan basket getirilmesi gerekiyor
        }

        public List<Order> GetOrderList(DateTime? dt, object search)
        {
            if (dt != null)
            {
                return _dal.GetListAll(new string[] { "Customer","OrderDetails", "OrderDetails.ProductSkus" }).Where(w => w.CompanyId == 4 && w.Status == true && w.OrderDate.Date == Convert.ToDateTime(dt).Date).ToList();
            }
            else
            {
                var id = 0;
                var value = Convert.ToString(search);
                if (int.TryParse(value, out id))
                {
                    return _dal.GetListAll(new string[] { "Customer", "OrderDetails" }).Where(w => w.CompanyId == 4 && w.Status == true && w.Id ==id ).ToList();
                }
                else
                {
                    return _dal.GetListAll(new string[] { "Customer", "OrderDetails" }).Where(w => w.CompanyId == 4 && w.Status == true && w.Customer.Name.Contains(value)).ToList();
                }

            }

        }

        public Order UpdateOrder(Order order)
        {
            return _dal.Update(order);
        }
    }
}
