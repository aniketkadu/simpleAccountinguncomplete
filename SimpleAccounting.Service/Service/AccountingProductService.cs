using AutoMapper;
using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Repository.Infrastructure;
using SimpleAccounting.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
  public  class AccountingProductService: IAccountingProductService
    {
        private readonly IAccountingProductRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingProductService(IAccountingProductRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<AccountingProductDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingProduct, AccountingProductDtos>);
        }

        public void AddUser(AccountingProductDtos person)
        {
            var company = Mapper.Map<AccountingProductDtos, AccountingProduct>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingProductDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.ProductId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }

        public AccountingProductDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingProduct, AccountingProductDtos>).Where(x => x.ProductId == Id).FirstOrDefault();
        }

        public void Delete(AccountingProductDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.ProductId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }
    }
}
