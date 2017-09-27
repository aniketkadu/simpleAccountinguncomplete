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
   public class AccountingSalesOrderService: IAccountingSalesOrderService
    {

        private readonly IAccountingSalesOrderRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingSalesOrderService(IAccountingSalesOrderRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<AccountingSalesOrderDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesOrder, AccountingSalesOrderDtos>);
        }

        public void AddUser(AccountingSalesOrderDtos person)
        {
            var company = Mapper.Map<AccountingSalesOrderDtos, AccountingSalesOrder>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

       
        public AccountingSalesOrderDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesOrder, AccountingSalesOrderDtos>).Where(x => x.SalesOrderId == Id).FirstOrDefault();

        }

        public void Delete(AccountingSalesOrderDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesOrderId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingSalesOrderDtos company, int Id)
        {

            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesOrderId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }
    }
}
