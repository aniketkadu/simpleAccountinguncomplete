using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.IService
{
   public interface IAccountingSalesInvoiceService
    {

        IEnumerable<AccountingSalesInvoiceDtos> GetAllCustomers();
        void AddUser(AccountingSalesInvoiceDtos person);

        void UpdateDetails(AccountingSalesInvoiceDtos company, int Id);

        AccountingSalesInvoiceDtos GetById(int Id);

        void Delete(AccountingSalesInvoiceDtos company, int Id);
    }
}
