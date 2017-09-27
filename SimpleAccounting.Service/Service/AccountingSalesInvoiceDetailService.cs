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
   public class AccountingSalesInvoiceDetailService: IAccountingSalesInvoiceDetailService
    {
        private readonly IAccountingSalesInvoiceDetailRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public AccountingSalesInvoiceDetailService(IAccountingSalesInvoiceDetailRepository customerRepository, IUnitOfWork unitOfWork)
        {

            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<AccountingSalesInvoiceDetailDtos> GetAllCustomers()
        {
            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesInvoiceDetail, AccountingSalesInvoiceDetailDtos>);
        }

        public void AddUser(AccountingSalesInvoiceDetailDtos person)
        {
            var company = Mapper.Map<AccountingSalesInvoiceDetailDtos, AccountingSalesInvoiceDetail>(person);
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
            customerRepository.Add(company);
            unitOfWork.Commit();
        }

        

        public AccountingSalesInvoiceDetailDtos GetById(int Id)
        {

            return customerRepository.GetAll().Select(Mapper.Map<AccountingSalesInvoiceDetail, AccountingSalesInvoiceDetailDtos>).Where(x => x.SalesInvoiceDetailId == Id).FirstOrDefault();


        }

        public void Delete(AccountingSalesInvoiceDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesInvoiceDetailId == Id);
            customerRepository.Delete(customerInDb);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingSalesInvoiceDetailDtos company, int Id)
        {
            var customerInDb = customerRepository.GetAll().SingleOrDefault(c => c.SalesInvoiceDetailId == Id);
            Mapper.Map(company, customerInDb);
            unitOfWork.Commit();
        }
    }
}
