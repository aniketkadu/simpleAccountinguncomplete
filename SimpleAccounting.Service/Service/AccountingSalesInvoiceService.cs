using AutoMapper;
using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Repository;
using SimpleAccounting.Repository.Infrastructure;
using SimpleAccounting.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.Service
{
 public   class AccountingSalesInvoiceService: IAccountingSalesInvoiceService
    {
        private readonly IAccountingSalesInvoiceRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingSalesInvoiceService(IAccountingSalesInvoiceRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<AccountingSalesInvoiceDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesInvoice, AccountingSalesInvoiceDtos>);
        }

        public void AddUser(AccountingSalesInvoiceDtos person)
        {
            var company = Mapper.Map<AccountingSalesInvoiceDtos, AccountingSalesInvoice>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

     

        public AccountingSalesInvoiceDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesInvoice, AccountingSalesInvoiceDtos>).Where(x => x.SalesInvoiceId == Id).FirstOrDefault();

        }

        public void Delete(AccountingSalesInvoiceDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesInvoiceId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingSalesInvoiceDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesInvoiceId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }
    }
}
