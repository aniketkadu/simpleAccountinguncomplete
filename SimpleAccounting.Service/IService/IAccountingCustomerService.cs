using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
  public  interface IAccountingCustomerService
    {
        IEnumerable<AccountingCustomerDtos> GetAllCustomers();
        void AddUser(AccountingCustomerDtos person);

        void UpdateDetails(AccountingCustomerDtos company,int Id);
        AccountingCustomerDtos GetById(int Id);

        void Delete(AccountingCustomerDtos company, int Id);
    }
}
