using SimpleAccounting.Model.Model;
using SimpleAccounting.Repository.Infrastructure;
using SimpleAccounting.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository.Repository
{
public    class AccountingLoginRepository : RepositoryBase<AccountingLogin>, IAccountingLoginRepository
    {
        public AccountingLoginRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {
                
        }
    }
}
