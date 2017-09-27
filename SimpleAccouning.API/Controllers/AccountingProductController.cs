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
    public class AccountingProductController : ApiController
    {
        private readonly IAccountingProductService customerRepository;

        public AccountingProductController(IAccountingProductService userRepo)
        {
            this.customerRepository = userRepo;

        }

        [HttpGet]
        public IEnumerable<AccountingProductDtos> Get()
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
        public IHttpActionResult CreateCustomer(AccountingProductDtos customerDto)
        {
            try {
                if (!ModelState.IsValid)
                    return BadRequest();


                customerRepository.AddUser(customerDto);


                return Created(new Uri(Request.RequestUri + "/" + customerDto.ProductId), customerDto);
            }
            catch
            {
                throw;
            }
            }

    }
}
