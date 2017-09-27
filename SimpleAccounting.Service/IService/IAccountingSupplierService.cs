using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.IService
{
  public  interface IAccountingSupplierService
    {
        IEnumerable<AccountingSupplierDtos> GetAllCustomers();
        void AddUser(AccountingSupplierDtos person);

        void UpdateDetails(AccountingSupplierDtos company, int Id);
        AccountingSupplierDtos GetById(int Id);

        void Delete(AccountingSupplierDtos company, int Id);
    }
}
