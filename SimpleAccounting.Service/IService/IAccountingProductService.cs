using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
  public  interface IAccountingProductService
    {
        IEnumerable<AccountingProductDtos> GetAllCustomers();
        void AddUser(AccountingProductDtos person);

        void UpdateDetails(AccountingProductDtos
            company, int Id);

        AccountingProductDtos GetById(int Id);

        void Delete(AccountingProductDtos company, int Id);
    }
}
