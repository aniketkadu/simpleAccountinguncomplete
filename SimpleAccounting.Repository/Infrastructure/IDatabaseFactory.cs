using SimpleAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        SimpleAccountingContext Get();
    }
}
