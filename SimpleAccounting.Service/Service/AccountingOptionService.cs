using AutoMapper;
using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Repository;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
  public  class AccountingOptionService: IAccountingOptionService
    {
        private readonly IAccountingOptionRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountingOptionService(IAccountingOptionRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }


        public IEnumerable<AccountingOptionDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingOption, AccountingOptionDtos>);
        }

        public void AddUser(AccountingOptionDtos person)
        {
            var company = Mapper.Map<AccountingOptionDtos, AccountingOption>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingOptionDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.OptionId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }

        public AccountingOptionDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingOption, AccountingOptionDtos>).Where(x => x.OptionId == Id).FirstOrDefault();
        }

        public void Delete(AccountingOptionDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.OptionId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }
    }
}
