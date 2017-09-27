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
    class AccountingSalesOrderDetailService: IAccountingSalesOrderDetailService
    {

        private readonly IAccountingSalesOrderDetailRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingSalesOrderDetailService(IAccountingSalesOrderDetailRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<AccountingSalesOrderDetailDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesOrderDetail, AccountingSalesOrderDetailDtos>);
        }

        public void AddUser(AccountingSalesOrderDetailDtos person)
        {
            var company = Mapper.Map<AccountingSalesOrderDetailDtos, AccountingSalesOrderDetail>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingSalesOrderDetailDtos company)
        {
            var varcha = Mapper.Map<AccountingSalesOrderDetailDtos, AccountingSalesOrderDetail>(company);
            unitOfWork.Commit();
        }

        public AccountingSalesOrderDetailDtos GetById(int Id)
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesOrderDetail, AccountingSalesOrderDetailDtos>).Where(x => x.SalesOrderDetailId == Id).FirstOrDefault();

        }

        public void Delete(AccountingSalesOrderDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesOrderDetailId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingSalesOrderDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesOrderDetailId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }

  
    }
}
