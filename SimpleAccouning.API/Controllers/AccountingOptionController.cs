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
    public class AccountingOptionController : ApiController
    {

        private readonly IAccountingOptionService customerRepository;

        public AccountingOptionController(IAccountingOptionService userRepo)
        {
            this.customerRepository = userRepo;
        }

        [HttpGet]
        public IEnumerable<AccountingOptionDtos> Get()
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
        public IHttpActionResult CreateCustomer(AccountingOptionDtos customerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();


                customerRepository.AddUser(customerDto);

                return Created(new Uri(Request.RequestUri + "/" + customerDto.OptionId), customerDto);

            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public IEnumerable<AccountingOptionDtos> Get(int Id)
        {

            yield return customerRepository.GetById(Id);
        }

        [HttpPut]
        public IHttpActionResult Update(AccountingOptionDtos customerDto, int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                customerRepository.AddUser(customerDto);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.OptionId), customerDto);
            }
            catch
            {
                throw;
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(AccountingOptionDtos customerDto, int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                customerRepository.Delete(customerDto, Id);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.OptionId), customerDto);
            }
            catch
            {
                throw;
            }
        }
    }
}
