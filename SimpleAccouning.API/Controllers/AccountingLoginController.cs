using Microsoft.IdentityModel.Tokens;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Model.Model;
using SimpleAccounting.Service.IService;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SimpleAccouning.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AccountingLoginController : ApiController
    {
        private readonly IAccountingLoginService loginRepository;

        public AccountingLoginController(IAccountingLoginService userRepo)
        {
            this.loginRepository = userRepo;

        }
        //[HttpGet]
        //public IEnumerable<AccountingLoginDtos> Get(string userName, string word)
        //{
        //   var user= loginRepository.GetAllCustomers(userName, word).ToList();
        //    try
        //    {
        //        return loginRepository.GetAllCustomers(userName, word);

        //    }

        //    catch (System.Exception)
        //    {
        //        throw;
        //    }


        //}





        [HttpGet]
        public IEnumerable<AccountingLoginDtos> Get(string userName, string word)
        {
            yield return loginRepository.GetById(userName, word);
        }



        [HttpGet]
        public IEnumerable<AccountingLoginDtos> Get()
        {
            try
            {
                return loginRepository.GetLogin();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        //[HttpPost]
        //public IHttpActionResult CreateCustomer(AccountingLoginDtos customerDto)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //            return BadRequest();


        //        loginRepository.AddUser(customerDto);


        //        return Created(new Uri(Request.RequestUri + "/" + customerDto.UserId), customerDto);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        [AllowAnonymous]
        [Route("api/AccountingLogin/Login")]
        public IHttpActionResult Login(AccountingLoginDtos model)
        {
            bool userLoggedIn = loginRepository.Login(model);
            if(userLoggedIn==false)
            {
                return Unauthorized();
            }
            else
            {
                return Ok("LoginSuccessfull");
            }
        }
    }
}
