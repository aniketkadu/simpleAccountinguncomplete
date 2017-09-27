

using AutoMapper;
using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
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
  public  class AccountingSupplierService: IAccountingSupplierService
    {

        private readonly IAccountingSupplierRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingSupplierService(IAccountingSupplierRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<AccountingSupplierDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSupplier, AccountingSupplierDtos>);
        }

        public void AddUser(AccountingSupplierDtos person)
        {
            var company = Mapper.Map<AccountingSupplierDtos, AccountingSupplier>(person);
            //_context.Customers.Add(customer);
            //  _context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

   
        public AccountingSupplierDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSupplier, AccountingSupplierDtos>).Where(x => x.SupplierId == Id).FirstOrDefault();
        }

        public void Delete(AccountingSupplierDtos company, int Id)
        {

            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SupplierId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingSupplierDtos company, int Id)
        {

            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SupplierId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }
    }
}
