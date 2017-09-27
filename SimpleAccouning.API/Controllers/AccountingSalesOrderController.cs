using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleAccouning.API.Controllers
{
    public class AccountingSalesOrderController : ApiController
    {
        private readonly IAccountingSalesOrderService customerRepository;
        public AccountingSalesOrderController(IAccountingSalesOrderService userRepo)
        {
            this.customerRepository = userRepo;
        }


        [HttpGet]
        public IEnumerable<AccountingSalesOrderDtos> Get()
        {
            try
            {
                return customerRepository.GetAllCustomers();
            }
            catch (System.Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public IHttpActionResult CreateCustomer(AccountingSalesOrderDtos customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            // var customer = Mapper.Map<AccountingCompanyDetailDtos, AccountingCompanyDetail>(customerDto);
            customerRepository.AddUser(customerDto);
            //   customerRepository.SaveChanges();

            //  customerDto.CompanyId = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customerDto.SalesOrderId), customerDto);
        }


    }
}
