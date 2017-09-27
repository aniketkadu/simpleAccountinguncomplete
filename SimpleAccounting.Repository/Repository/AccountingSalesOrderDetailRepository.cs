using SimpleAccounting.Model;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
 public   class AccountingSalesOrderDetailRepository:RepositoryBase<AccountingSalesOrderDetail>, IAccountingSalesOrderDetailRepository
    {
        public AccountingSalesOrderDetailRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {

        }
    }
}
