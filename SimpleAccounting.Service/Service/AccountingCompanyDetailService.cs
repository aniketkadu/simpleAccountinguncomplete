using AutoMapper;
using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Repository;
using SimpleAccounting.Repository.Infrastructure;
using SimpleAccounting.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
 public   class AccountingCompanyDetailService : IAccountingCompanyDetailService
    {
        private readonly IAccountingCompanyDetailRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountingCompanyDetailService(IAccountingCompanyDetailRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<AccountingCompanyDetailDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingCompanyDetail, AccountingCompanyDetailDtos>); 
        }

        public void AddUser(AccountingCompanyDetailDtos person)
        {
            var company = Mapper.Map<AccountingCompanyDetailDtos, AccountingCompanyDetail>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingCompanyDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.CompanyId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }


        public AccountingCompanyDetailDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingCompanyDetail, AccountingCompanyDetailDtos>).Where(x => x.CompanyId == Id).FirstOrDefault();


        }

        public void Delete(AccountingCompanyDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.CompanyId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }
    }
}
