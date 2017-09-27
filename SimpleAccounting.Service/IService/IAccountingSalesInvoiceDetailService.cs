using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.IService
{
  public  interface IAccountingSalesInvoiceDetailService
    {
        IEnumerable<AccountingSalesInvoiceDetailDtos> GetAllCustomers();
        void AddUser(AccountingSalesInvoiceDetailDtos person);

        void UpdateDetails(AccountingSalesInvoiceDetailDtos company, int Id);

        AccountingSalesInvoiceDetailDtos GetById(int Id);

        void Delete(AccountingSalesInvoiceDetailDtos company, int Id);
    }
}
