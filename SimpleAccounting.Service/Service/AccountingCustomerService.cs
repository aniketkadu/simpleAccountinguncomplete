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
    class AccountingCustomerService: IAccountingCustomerService
    {
        private readonly IAccountingCustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingCustomerService(IAccountingCustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
     public   IEnumerable<AccountingCustomerDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingCustomer, AccountingCustomerDtos>);
        }

        public void AddUser(AccountingCustomerDtos person)
        {
            var company = Mapper.Map<AccountingCustomerDtos, AccountingCustomer>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingCustomerDtos company,int Id)
        {

            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.CustomerId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }

        public AccountingCustomerDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingCustomer, AccountingCustomerDtos>).Where(x=>x.CustomerId==Id).FirstOrDefault();


        }

        public void Delete(AccountingCustomerDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.CustomerId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }
    }
}
