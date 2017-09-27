using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.IService
{
    public interface IAccountingSalesOrderService
    {
        IEnumerable<AccountingSalesOrderDtos> GetAllCustomers();
        void AddUser(AccountingSalesOrderDtos person);

        void UpdateDetails(AccountingSalesOrderDtos company, int Id);
        AccountingSalesOrderDtos GetById(int Id);

        void Delete(AccountingSalesOrderDtos company, int Id);
    }
}
