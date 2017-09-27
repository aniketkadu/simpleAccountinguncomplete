using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleAccouning.API.Controllers
{
    public class AccountingCustomerController : ApiController
    {
        private readonly IAccountingCustomerService customerRepository;

        public AccountingCustomerController(IAccountingCustomerService userRepo)
        {
            this.customerRepository = userRepo;
        }

        [HttpGet]
        public IEnumerable<AccountingCustomerDtos> Get()
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
        [HttpGet]
        public IEnumerable<AccountingCustomerDtos> Get(int Id)
        {
            yield return customerRepository.GetById(Id);
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(AccountingCustomerDtos customerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();


                customerRepository.AddUser(customerDto);

                return Created(new Uri(Request.RequestUri + "/" + customerDto.CustomerId), customerDto);
            }
            catch
            {
                throw;
            }
            }

        [HttpPut]
        public IHttpActionResult Update(AccountingCustomerDtos customerDto, int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                customerRepository.AddUser(customerDto);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.CustomerId), customerDto);
            }
            catch
            {
                throw;
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(AccountingCustomerDtos customerDto, int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                customerRepository.Delete(customerDto, Id);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.CustomerId), customerDto);
            }
            catch
            {
                throw ;
            }
        }

    }
}
