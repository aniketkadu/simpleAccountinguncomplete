using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAccounting.Model.DTOS;

namespace SimpleAccounting.Service.IService
{
   public interface IAccountingLoginService
    {

   //     int Authenticate(string userName, string word);
        void AddUser(AccountingLoginDtos customerDto);
       
        IEnumerable<AccountingLoginDtos> GetLogin();
        AccountingLoginDtos GetById(string userName, string word);
        bool Login(AccountingLoginDtos model);
    }
}
