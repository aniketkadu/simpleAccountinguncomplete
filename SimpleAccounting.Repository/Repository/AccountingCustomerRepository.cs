using SimpleAccounting.Model;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
    class AccountingCustomerRepository : RepositoryBase<AccountingCustomer>, IAccountingCustomerRepository
    {
        public AccountingCustomerRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
