using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ChallengeController : ApiController
    {
        /// <summary>
        /// Calculates the volumne of a prism given lenght , width  and height
        /// </summary>
        /// <param name="x">The width of the prism in cm</param>
        /// <param name="y">The length of the prism in cm</param>
        /// <param name="z">The height of the prism in cm</param>
        /// <returns>
        /// The total volumne is {result}cm^3
        /// </returns>
        [HttpGet]
        [Route("api/challenge/calculate/{x}/{y}/{z}")]
        public string calculate(int x , int y , int z)

        {
            
            int volumne = x * y * z;
            string message = " Volume is " + volumne + "cm^3";
            return message;
        }

    }
}
