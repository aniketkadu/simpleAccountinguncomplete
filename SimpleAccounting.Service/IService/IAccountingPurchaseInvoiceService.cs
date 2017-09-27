using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
   public interface IAccountingPurchaseInvoiceService
    {
        IEnumerable<AccountingPurchaseInvoiceDtos> GetAllCustomers();
        void AddUser(AccountingPurchaseInvoiceDtos person);

        void UpdateDetails(AccountingPurchaseInvoiceDtos company, int Id);

        AccountingPurchaseInvoiceDtos GetById(int Id);

        void Delete(AccountingPurchaseInvoiceDtos company, int Id);
    }
}
