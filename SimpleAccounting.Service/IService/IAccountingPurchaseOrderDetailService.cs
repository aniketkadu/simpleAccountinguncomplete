using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
  public  interface IAccountingPurchaseOrderDetailService
    {
        IEnumerable<AccountingPurchaseOrderDetailDtos> GetAllCustomers();
        void AddUser(AccountingPurchaseOrderDetailDtos person);

        void UpdateDetails(AccountingPurchaseOrderDetailDtos company, int Id);


        AccountingPurchaseOrderDetailDtos GetById(int Id);

        void Delete(AccountingPurchaseOrderDetailDtos company, int Id);
    }
}
