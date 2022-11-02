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
    public class AccountTransactionManager : IAccountTransactionService
    {
        IAccountTransaction _dal;
        public AccountTransactionManager(IAccountTransaction dal)
        {
            _dal = dal;
        }

        public AccountTransaction AddCashPayout(AccountTransaction accountTransaction, string transactiontype)
        {

            accountTransaction.Description = transactiontype == "NAKTAH" ? "Nakit Tahsilat" : "Nakit Ödeme";
            accountTransaction.AccountTransactionTypeId = transactiontype == "NAKTAH" ? (short)5 : (short)6;//giriş yapılan tür. Para Girişi Seçildi. Tahsilatta olabilir.
            accountTransaction.CurrencyTypeId = 1;//TL olarak seçildi.
            accountTransaction.AccountDefinitionId = 18;// nakit kasa  . Hızlı satış için seçilmiş yada ödeme anında seçilecek kasa id
            accountTransaction.CompanyId = 4;
            return _dal.Insert(accountTransaction);
        }

        public AccountTransaction AddCreditCardPayout(AccountTransaction accountTransaction)
        {
            //accountTransaction.Description = "Kredi Kartı ile Tahsilat";
            accountTransaction.AccountTransactionTypeId = 5;//giriş yapılan tür. Para Girişi Seçildi. Tahsilatta olabilir.
            accountTransaction.CurrencyTypeId = 1;//TL olarak seçildi.
            accountTransaction.AccountDefinitionId = 14;// kredi kartı post  . Hızlı satış için seçilmiş yada ödeme anında seçilecek pos id
            accountTransaction.CompanyId = 4;
            return _dal.Insert(accountTransaction);
        }
    }
}
