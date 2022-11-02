using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IOrderService
    {
        Order AddOrder(Order order);
        OrderDetail AddOrderDetail(OrderDetail orderDetail);
        List<Order> GetOrderList(DateTime? dt, object search);
        List<OrderDetail> GetOrderDetailList(int? orderId);
        Order GetOrder(int orderId);
        OrderDetail GetOrderDetail(int orderDetailId);
        Order UpdateOrder(Order order);
    }
}
