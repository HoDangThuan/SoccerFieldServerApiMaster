using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoccerFieldServer.Infrastructure.Data;

namespace SoccerFieldServer.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SoccerFieldController : ControllerBase
    {
        private readonly SoccerFieldServerContext _context;

        public SoccerFieldController(SoccerFieldServerContext context)
        {
            _context = context;
        }

        [HttpGet("groupSoccerFieldID={groupSoccerFieldID}")]
        public IActionResult GetSoccerFieldByGroupSoccerFieldID(string groupSoccerFieldID)
        {
            if (_context is null) return null;
            var result = (from soccerField in _context.SoccerFields
                          where soccerField.GroupSoccerFieldId == groupSoccerFieldID
                          select new
                          {
                              id = soccerField.Id,
                              size = soccerField.Size,
                              kind = soccerField.Kind,
                              price = soccerField.Price,
                              isEnable = soccerField.IsEnable,
                              note = soccerField.Note
                          }).ToList();
            return Ok(result);
        }

        [HttpGet("Id={id}")]
        public IActionResult GetSoccerFieldById(string id)
        {
            if (_context is null) return null;
            var result = (from soccerField in _context.SoccerFields
                          where id == soccerField.Id
                          select new
                          {
                              id = soccerField.Id,
                              size = soccerField.Size,
                              kind = soccerField.Kind,
                              price = soccerField.Price,
                              isEnable = soccerField.IsEnable,
                              note = soccerField.Note
                          }).SingleOrDefault();
            if (result is null)
                return null;
            else
                return Ok(result);
        }

    }
}