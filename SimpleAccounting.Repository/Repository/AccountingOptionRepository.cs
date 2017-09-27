using SimpleAccounting.Model;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
    class AccountingOptionRepository : RepositoryBase<AccountingOption>, IAccountingOptionRepository
    {
        public AccountingOptionRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
