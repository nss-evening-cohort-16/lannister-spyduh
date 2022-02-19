using Lannister_Spyduh.DataAccess;
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

        



        // [HttpPost]

    }
}
