using AutoMapper;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Model.Model;
using SimpleAccounting.Repository.Infrastructure;
using SimpleAccounting.Repository.IRepository;
using SimpleAccounting.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.Service
{
 public   class AccountingLoginService: IAccountingLoginService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountingLoginRepository _UserRepository;
        public AccountingLoginService(IAccountingLoginRepository UserRepository, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._UserRepository = UserRepository;
        }

        public void AddUser(AccountingLoginDtos person)
        {
            var company = Mapper.Map<AccountingLoginDtos, AccountingLogin>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            _UserRepository.Add(company);
            _unitOfWork.Commit();
        }

        //public int Authenticate(string userName, string word)
        //{
        //    var user = _UserRepository.GetAll().Select(Mapper.Map<AccountingLogin, AccountingLoginDtos>).Where(x => x.UserName == userName && x.Password == word);
        //    //if(user!=null && user)
        //    if (user != null && user.UserId > 0)
        //    //{
        //    //    return user.UserId;
        //    //}
        //    return 0;
        //}

       

        public AccountingLoginDtos GetById(string userName, string word)
        {
            var user = _UserRepository.GetAll().Select(Mapper.Map<AccountingLogin, AccountingLoginDtos>);
            if (user != null)
            {
                return user.Where(x => x.UserName == userName && x.Password == word).Single();
            }
            return null;
        }

        public IEnumerable<AccountingLoginDtos> GetLogin()
        {
            return _UserRepository.GetAll().Select(Mapper.Map<AccountingLogin, AccountingLoginDtos>);
        }

        public bool Login(AccountingLoginDtos model )
        {
         var user=   _UserRepository.GetAll().Select(Mapper.Map<AccountingLogin, AccountingLoginDtos>).SingleOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    }
