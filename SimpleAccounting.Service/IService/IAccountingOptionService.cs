using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
  public  interface IAccountingOptionService
    {
        IEnumerable<AccountingOptionDtos> GetAllCustomers();
        void AddUser(AccountingOptionDtos person);

        void UpdateDetails(AccountingOptionDtos company, int Id);

        AccountingOptionDtos GetById(int Id);

        void Delete(AccountingOptionDtos company, int Id);
    }
}
