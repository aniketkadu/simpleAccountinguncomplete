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
   public class AccountingSupplierRepository:RepositoryBase<AccountingSupplier>, IAccountingSupplierRepository
    {
        public AccountingSupplierRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {

        }
    }
}
