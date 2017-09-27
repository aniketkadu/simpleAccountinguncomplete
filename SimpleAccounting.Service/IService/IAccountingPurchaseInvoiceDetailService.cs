using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
   public interface IAccountingPurchaseInvoiceDetailService
    {
        IEnumerable<AccountingPurchaseInvoiceDetailDtos> GetAllCustomers();
        void AddUser(AccountingPurchaseInvoiceDetailDtos person);

        void UpdateDetails(AccountingPurchaseInvoiceDetailDtos company, int Id);
        AccountingPurchaseInvoiceDetailDtos GetById(int Id);

        void Delete(AccountingPurchaseInvoiceDetailDtos company, int Id);
    }
}
