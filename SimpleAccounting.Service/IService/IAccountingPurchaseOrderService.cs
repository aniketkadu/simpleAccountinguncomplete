using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.IService
{
   public interface IAccountingPurchaseOrderService
    {
        IEnumerable<AccountingPurchaseOrderDtos> GetAllCustomers();
        void AddUser(AccountingPurchaseOrderDtos person);

        void UpdateDetails(AccountingPurchaseOrderDtos company, int Id);

        AccountingPurchaseOrderDtos GetById(int Id);

        void Delete(AccountingPurchaseOrderDtos company, int Id);
    }
}
