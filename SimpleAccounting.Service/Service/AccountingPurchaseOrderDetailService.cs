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
   public class AccountingPurchaseOrderDetailService: IAccountingPurchaseOrderDetailService
    {
        private readonly IAccountingPurchaseOrderDetailRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingPurchaseOrderDetailService(IAccountingPurchaseOrderDetailRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<AccountingPurchaseOrderDetailDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseOrderDetail, AccountingPurchaseOrderDetailDtos>);
        }

        public void AddUser(AccountingPurchaseOrderDetailDtos person)
        {
            var company = Mapper.Map<AccountingPurchaseOrderDetailDtos, AccountingPurchaseOrderDetail>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingPurchaseOrderDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseOrderId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }

        public AccountingPurchaseOrderDetailDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingPurchaseOrderDetail, AccountingPurchaseOrderDetailDtos>).Where(x => x.PurchaseOrderId == Id).FirstOrDefault();


        }

        public void Delete(AccountingPurchaseOrderDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.PurchaseOrderId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }
    }
}
