using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoccerFieldServer.Core.Entities;
using SoccerFieldServer.Infrastructure.Data;

namespace SoccerFieldServer.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /*
        private readonly SoccerFieldServerContext _context;

        public CustomerController(SoccerFieldServerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            if (_context is null) return null;
            var result = (from customer in _context.Customers
                          select new
                          {
                              id = customer.Id,
                              name = customer.Name,
                              passWord = customer.PassWord,
                              dateOfBirth = customer.DateOfBirth,
                              address = customer.Address,
                              email = customer.Email,
                              phoneNumber = customer.PhoneNumber,
                              bankAcount = customer.BankAcount,
                              status = customer.Status,
                              note = customer.Note
                          }).ToList();
            return Ok(result);
        }

        [HttpPost]
        public bool AddCustomer(string id, string name, string passWord, DateTime dateOfBirth,
            string address, string email, string phoneNumber, string bankAcount, bool status, string note)
        {
            Customer customer = new Customer
            {
                Id = id,
                Name = name,
                PassWord = passWord,
                DateOfBirth = dateOfBirth,
                Address = address,
                Email = email,
                PhoneNumber = phoneNumber,
                BankAcount = bankAcount,
                Status = status,
                Note = note
            };
            try
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        */
    }
}