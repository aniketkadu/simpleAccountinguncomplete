using SimpleAccounting.Model;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
public    class AccountingSalesInvoiceRepository:RepositoryBase<AccountingSalesInvoice>, IAccountingSalesInvoiceRepository
    {
        public AccountingSalesInvoiceRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {
                
        }
    }
}
