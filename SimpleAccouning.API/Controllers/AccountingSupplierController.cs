using SimpleAccounting.Model;
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
    public class AccountingSupplierController : ApiController
    {
        private readonly IAccountingSupplierService suplierRepository;

        public AccountingSupplierController(IAccountingSupplierService userRepo)
        {

            this.suplierRepository = userRepo;

        }
        [HttpGet]
        public IEnumerable<AccountingSupplierDtos> Get()
        {
            try
            {
                return suplierRepository.GetAllCustomers();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IEnumerable<AccountingSupplierDtos> Get(int Id)
        {
            yield return suplierRepository.GetById(Id);
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(AccountingSupplierDtos customerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();


                suplierRepository.AddUser(customerDto);

                return Created(new Uri(Request.RequestUri + "/" + customerDto.SupplierId), customerDto);
            }
            catch
            {
                throw;
            }
        }


        [HttpPut]
        public IHttpActionResult Update(AccountingSupplierDtos customerDto, int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                suplierRepository.AddUser(customerDto);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.SupplierId), customerDto);
            }
            catch
            {
                throw;
            }
        }


        [HttpDelete]
        public IHttpActionResult Delete(AccountingSupplierDtos customerDto, int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                suplierRepository.Delete(customerDto, Id);
                return Created(new Uri(Request.RequestUri + "/" + customerDto.SupplierId), customerDto);
            }
            catch
            {
                throw;
            }
        }









    }


   

}
