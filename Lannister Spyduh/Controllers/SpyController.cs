using Lannister_Spyduh.DataAccess;
using Lannister_Spyduh.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lannister_Spyduh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpyController : ControllerBase
    {
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


        /* [HttpGet("{spies/{enemies}")]
         // Conditional for Enemy Spy Method.
         if (spy.Faction != user.Faction && spy.Faction != 0){
         // This spy is an enemy!
         };*/


        // [HttpPost]

        SpyRepository _spyRepo = new SpyRepository();


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
