using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoccerFieldServer.Infrastructure.Data;

namespace SoccerFieldServer.api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class GroupSoccerFieldController : ControllerBase
    {
        private readonly SoccerFieldServerContext _context;

        public GroupSoccerFieldController(SoccerFieldServerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetGroupSoccerFieldList()
        {
            if (_context is null) return null;
            var result = (from groupSoccerField in _context.GroupSoccerFields
                          select new
                          {
                              id = groupSoccerField.Id,
                              name = groupSoccerField.Name,
                              address = groupSoccerField.Address,
                              district = groupSoccerField.District,
                              country = groupSoccerField.Country,
                              openTime = groupSoccerField.OpenTime,
                              closeTime = groupSoccerField.CloseTime,
                              percentVAT = groupSoccerField.PercentVAT,
                              percentRushHour = groupSoccerField.PercentRushHour,
                              percentPunish = groupSoccerField.PercentPunish,
                              isEnable = groupSoccerField.IsEnable,
                              note = groupSoccerField.Note
                          }).ToList();
            if (result is null)
                return null;
            else
                return Ok(result);
        }
        
        [HttpGet("Id={id}")]
        public IActionResult GetGroupSoccerFieldListById(string id)
        {
            if (_context is null) return null;
            var result = (from groupSoccerField in _context.GroupSoccerFields
                          where id == groupSoccerField.Id
                          select new
                          {
                              id = groupSoccerField.Id,
                              name = groupSoccerField.Name,
                              address = groupSoccerField.Address,
                              district = groupSoccerField.District,
                              country = groupSoccerField.Country,
                              openTime = groupSoccerField.OpenTime,
                              closeTime = groupSoccerField.CloseTime,
                              percentVAT = groupSoccerField.PercentVAT,
                              percentRushHour = groupSoccerField.PercentRushHour,
                              percentPunish = groupSoccerField.PercentPunish,
                              isEnable = groupSoccerField.IsEnable,
                              note = groupSoccerField.Note
                          }).SingleOrDefault();
            if (result is null)
                return null;
            else
                return Ok(result);
        }
        
        [HttpGet("district={district}")]
        public IActionResult GetGroupSoccerFieldListByDistrict(string district)
        {
            if (_context is null) return null;
            var result = (from groupSoccerField in _context.GroupSoccerFields
                          where district == groupSoccerField.District
                          select new
                          {
                              id = groupSoccerField.Id,
                              name = groupSoccerField.Name,
                              address = groupSoccerField.Address,
                              district = groupSoccerField.District,
                              country = groupSoccerField.Country,
                              openTime = groupSoccerField.OpenTime,
                              closeTime = groupSoccerField.CloseTime,
                              percentVAT = groupSoccerField.PercentVAT,
                              percentRushHour = groupSoccerField.PercentRushHour,
                              percentPunish = groupSoccerField.PercentPunish,
                              isEnable = groupSoccerField.IsEnable,
                              note = groupSoccerField.Note
                          }).ToList();
            if (result is null)
                return null;
            else
                return Ok(result);
        }

    }
}