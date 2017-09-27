using SimpleAccounting.Model;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
   public class AccountingCompanyDetailRepository : RepositoryBase<AccountingCompanyDetail>, IAccountingCompanyDetailRepository
    {
        public AccountingCompanyDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
