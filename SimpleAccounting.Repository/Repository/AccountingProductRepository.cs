using SimpleAccounting.Model;
using SimpleAccounting.Repository.Infrastructure;
using SimpleAccounting.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository.Repository
{
    class AccountingProductRepository:RepositoryBase<AccountingProduct>, IAccountingProductRepository
    {
        public AccountingProductRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {

        }
    }
}
