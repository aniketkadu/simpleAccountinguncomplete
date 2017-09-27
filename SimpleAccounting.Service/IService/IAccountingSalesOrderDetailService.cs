using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.IService
{
  public  interface IAccountingSalesOrderDetailService
    {
        IEnumerable<AccountingSalesOrderDetailDtos> GetAllCustomers();
        void AddUser(AccountingSalesOrderDetailDtos person);

        void UpdateDetails(AccountingSalesOrderDetailDtos company, int Id);
        AccountingSalesOrderDetailDtos GetById(int Id);

        void Delete(AccountingSalesOrderDetailDtos company, int Id);
    }
}
