
using Lannister_Spyduh.DataAccess;
using Lannister_Spyduh.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lannister_Spyduh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class SpyController : ControllerBase
    {

        SpyRepository _spyRepo = new SpyRepository();

        /* [HttpGet("skill/{skillType}")]
         [HttpGet("spies/{mySpy}/{skillType}")] ??????????????????????????????????????
         var mySpy = Spy
         mySpy.Skills
          mySpy.Services */

        // add

        /* [HttpGet("{spies/{friendlies}")]
         // Conditional for Friendly Spy Method.
         if (spy.Faction = user.Faction)
        {
            // This spy is an friendly!
         }; */


        [HttpGet("spies/{teamSpy}")]
        public IActionResult GetSpyByFaction(Faction teamSpy)
        {
            var matches = _spyRepo.GetTeamSpies(teamSpy);

            if (matches != null)
            {
                return Ok(matches);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult PostNewSpy(Spy newSpy)
        {
            if (!ValidNewSpy(newSpy))
            {
                return BadRequest(newSpy);
            }
            else
            {
                _spyRepo.Post(newSpy);
                return Ok();
            }
        }

        private bool ValidNewSpy(Spy newSpy)
        {
            if (newSpy == null)
            {
                return false;
            }
            if (newSpy.CodeName == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(newSpy.CodeName))
            {
                return false;
            }
            return true;
        }
    }
}
