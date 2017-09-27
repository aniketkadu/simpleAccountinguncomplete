using AutoMapper;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Model;
using SimpleAccounting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Data;

namespace SimpleAccouning.API.Controllers
{
    [EnableCors(origins:"http://localhost:4200",headers:"*",methods:"*")]
    public class AccountingCompanyDetailController : ApiController
    {
        private readonly IAccountingCompanyDetailService customerRepository;
       
        public AccountingCompanyDetailController(IAccountingCompanyDetailService userRepo)
        {
            this.customerRepository = userRepo;
        }

        /// <summary>
        /// for getting all company details
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IEnumerable<AccountingCompanyDetailDtos> Get()
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

        /// <summary>
        /// for adding new company details
        /// </summary>
        ///// <param name="person"></param>
        //[HttpPost]

        //public void post(AccountingCompanyDetail person)
        //{
        //    customerRepository.AddUser(person);
        //}


        /// <summary>
        /// To get single company details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /*   public IHttpActionResult GetCustomer(int id)
           {
               var customer = customerRepository.GetAllCustomers().SingleOrDefault(c => c.CompanyId == id);

               if (customer == null)
                   return NotFound();

               return Ok(Mapper.Map<AccountingCompanyDetailDtos, AccountingCompanyDetail>(customer));
           }*/



        /// <summary>
        /// adds company details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult CreateCustomer(AccountingCompanyDetailDtos customerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                customerRepository.AddUser(customerDto);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.CompanyId), customerDto);
            }
            catch
            {
                throw;
            }
            }


     

            /// <summary>
            /// for updating company details
            /// </summary>
            /// <param name="customerDto"></param>
            /// <param name="Id"></param>
            /// <returns></returns>
        [HttpPut]
        public IHttpActionResult Update(AccountingCompanyDetailDtos customerDto, int Id)
        {
            try
            {

                if (!ModelState.IsValid)
                    return BadRequest();
                customerRepository.UpdateDetails(customerDto, Id);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.CompanyId), customerDto);
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// deleting entries of perticular ID
        /// </summary>
        /// <param name="customerDto"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IHttpActionResult Delete(AccountingCompanyDetailDtos customerDto, int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                customerRepository.Delete(customerDto, Id);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.CompanyId), customerDto);
            }
            catch
            {
                throw;
            }
        }

    }

}

