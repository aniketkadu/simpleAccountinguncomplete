using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
    public interface IAccountingCompanyDetailService
    {
        IEnumerable<AccountingCompanyDetailDtos> GetAllCustomers();
        void AddUser(AccountingCompanyDetailDtos person);

        void UpdateDetails(AccountingCompanyDetailDtos company, int Id);
        AccountingCompanyDetailDtos GetById(int Id);

        void Delete(AccountingCompanyDetailDtos company, int Id);

    }
}
