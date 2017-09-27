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
  public  class AccountingPurchaseOrderService: IAccountingPurchaseOrderService
    {
        private readonly IAccountingPurchaseOrderRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingPurchaseOrderService(IAccountingPurchaseOrderRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<AccountingPurchaseOrderDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseOrder, AccountingPurchaseOrderDtos>);
        }

        public void AddUser(AccountingPurchaseOrderDtos person)
        {
            var company = Mapper.Map<AccountingPurchaseOrderDtos, AccountingPurchaseOrder>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

      

        public AccountingPurchaseOrderDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseOrder, AccountingPurchaseOrderDtos>).Where(x => x.PurchaseOrderId == Id).FirstOrDefault();

        }

        public void Delete(AccountingPurchaseOrderDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseOrderId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingPurchaseOrderDtos company, int Id)
        {

            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseOrderId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }
    }
}
