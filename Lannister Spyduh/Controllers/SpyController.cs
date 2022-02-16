using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lannister_Spyduh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpyController : ControllerBase
    {
<<<<<<< HEAD
       /* [HttpGet("skill/{skillType}")]

        [HttpGet("spies/{mySpy}/{skillType}")] ??????????????????????????????????????
        var mySpy = Spy
        mySpy.Skills
         mySpy.Services */


=======
        /* [HttpGet("skill/{skillType}")]
         [HttpGet("spies/{mySpy}/{skillType}")] ??????????????????????????????????????
         var mySpy = Spy
         mySpy.Skills
          mySpy.Services */
>>>>>>> b1565cfb83f4d2619f025aa11c3f2c37e7a661d6
        /* [HttpGet("{spies/{friendlies}")]
         // Conditional for Friendly Spy Method.
         if (spy.Faction = user.Faction)
        {
            // This spy is an friendly!
         }; */
<<<<<<< HEAD


       /* [HttpGet("{spies/{enemies}")]
        // Conditional for Enemy Spy Method.
        if (spy.Faction != user.Faction && spy.Faction != 0){
        // This spy is an enemy!
        };*/


    // [HttpPost]

=======
        /* [HttpGet("{spies/{enemies}")]
         // Conditional for Enemy Spy Method.
         if (spy.Faction != user.Faction && spy.Faction != 0){
         // This spy is an enemy!
         };*/
        // [HttpPost]
>>>>>>> b1565cfb83f4d2619f025aa11c3f2c37e7a661d6
    }
}
