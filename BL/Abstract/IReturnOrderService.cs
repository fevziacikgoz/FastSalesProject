using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IReturnOrderService
    {
        ReturnOrder AddOrder(ReturnOrder order);
        ReturnOrderDetail AddOrderDetail(ReturnOrderDetail orderDetail);
        ReturnOrder GetReturnOrder(int id);
        List<ReturnOrderDetail> GetReturnOrderDetailList(int? returnorderId);
        ReturnOrder UpdateReturnOrder(ReturnOrder returnOrder);
    }
}
