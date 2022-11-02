using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IAccountTransactionService
    {
        AccountTransaction AddCashPayout(AccountTransaction accountTransaction, string transactiontype);
        AccountTransaction AddCreditCardPayout(AccountTransaction accountTransaction);
    }
}
