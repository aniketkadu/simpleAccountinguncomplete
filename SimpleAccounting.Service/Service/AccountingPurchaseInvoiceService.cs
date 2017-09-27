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
  public  class AccountingPurchaseInvoiceService: IAccountingPurchaseInvoiceService
    {
        private readonly IAccountingPurchaseInvoiceRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingPurchaseInvoiceService(IAccountingPurchaseInvoiceRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<AccountingPurchaseInvoiceDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseInvoice, AccountingPurchaseInvoiceDtos>);
        }

        public void AddUser(AccountingPurchaseInvoiceDtos person)
        {
            var company = Mapper.Map<AccountingPurchaseInvoiceDtos, AccountingPurchaseInvoice>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingPurchaseInvoiceDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseInvoiceId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }

        public AccountingPurchaseInvoiceDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseInvoice, AccountingPurchaseInvoiceDtos>).Where(x => x.PurchaseInvoiceId == Id).FirstOrDefault();

        }

        public void Delete(AccountingPurchaseInvoiceDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseInvoiceId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }
    }
}
