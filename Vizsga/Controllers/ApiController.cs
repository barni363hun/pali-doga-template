using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vizsga.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly AppContext _appContext;

        public ApiController(AppContext appContext)
        {
            _appContext = appContext;
        }

        //[HttpGet("api/competitors")]
        //public ActionResult Get()
        //{
        //    return Ok
        //    (
        //        _appContext.Set<CompetitorModel>()
        //                   .Include(c => c.Profession)
        //                   .Select(c => new
        //                   {
        //                       c.Id,
        //                       Profession = c.Profession.Name,
        //                       c.SchoolName,
        //                       c.Name,
        //                       BirthDate = $"{c.BirthDate:yyyy-MM-dd}",
        //                       c.Hostel,
        //                       c.AvatarUrl
        //                   })
        //    );
        //}

        //[HttpPost("api/newcompetitor")]
        //public ActionResult Post(dynamic data)
        //{
        //    try
        //    {
        //        var competitor = System.Text.Json.JsonSerializer
        //                        .Deserialize<CompetitorModel>(
        //                            data.ToString(),
        //                            new System.Text.Json.JsonSerializerOptions()
        //                            {
        //                                PropertyNameCaseInsensitive = true
        //                            }
        //                        );
        //        _appContext.Set<CompetitorModel>().Add(competitor);
        //        _appContext.SaveChanges();
        //        return StatusCode(201, new
        //        {
        //            id = competitor.Id
        //        });
        //    }
        //    catch
        //    {
        //        return BadRequest("Hiányos adatok.");
        //    }
        //}

        //[HttpDelete("api/competitor/{id}")]
        //public ActionResult Delete(int id)
        //{
        //    var competitor = _appContext.Set<CompetitorModel>().FirstOrDefault(c => c.Id == id);
        //    if (competitor == null)
        //        return NotFound("A megadott azonosítóval nem létezik versenyző");
            
        //    _appContext.Remove(competitor);
        //    _appContext.SaveChanges();
        //    return NoContent();
        //}


        //[HttpGet("api/professions")]
        //public ActionResult Professions()
        //{
        //    return Ok(_appContext.Set<ProfessionModel>().ToList());
        //}
    }
}
