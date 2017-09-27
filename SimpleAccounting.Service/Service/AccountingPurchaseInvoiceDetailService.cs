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
   public class AccountingPurchaseInvoiceDetailService: IAccountingPurchaseInvoiceDetailService
    {
        private readonly IAccountingPurchaseInvoiceDetailRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingPurchaseInvoiceDetailService(IAccountingPurchaseInvoiceDetailRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<AccountingPurchaseInvoiceDetailDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseInvoiceDetail, AccountingPurchaseInvoiceDetailDtos>);
        }

        public void AddUser(AccountingPurchaseInvoiceDetailDtos person)
        {
            var company = Mapper.Map<AccountingPurchaseInvoiceDetailDtos, AccountingPurchaseInvoiceDetail>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingPurchaseInvoiceDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseInvoiceDetailId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }

        public AccountingPurchaseInvoiceDetailDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseInvoiceDetail, AccountingPurchaseInvoiceDetailDtos>).Where(x => x.PurchaseInvoiceDetailId == Id).FirstOrDefault();
        }

        public void Delete(AccountingPurchaseInvoiceDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseInvoiceDetailId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }
    }
}
