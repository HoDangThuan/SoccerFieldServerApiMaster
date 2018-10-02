using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoccerFieldServer.Core.Entities;
using SoccerFieldServer.Infrastructure.Data;

namespace SoccerFieldServer.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly SoccerFieldServerContext _context;

        public ProductController(SoccerFieldServerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProductById(string id)
        {
            if (_context is null) return null;
            var result = (from product in _context.Products
                          where id == product.Id
                          select new
                          {
                              id = product.Id,
                              name = product.Name,
                              amount = product.Amount,
                              price = product.Price,
                              isEnable = product.IsEnable,
                              note = product.Note,
                              groupSoccerFieldId = product.GroupSoccerFieldId
                          }).SingleOrDefault();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            if (_context is null) return null;
            var result = (from product in _context.Products
                          select new
                          {
                              id = product.Id,
                              name = product.Name,
                              amount = product.Amount,
                              price = product.Price,
                              isEnable = product.IsEnable,
                              note = product.IsEnable,
                              groupSoccerFieldId = product.GroupSoccerFieldId
                          }).ToList();
            return Ok(result);
        }

        [HttpPost]
        public bool AddProduct([FromForm] Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        [HttpPut]
        public bool UpdateProduct([FromForm] Product product)
        {
            try
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}