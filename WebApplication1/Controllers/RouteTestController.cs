using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class RouteTestController : ApiController
    {
        //get: api/RouteTest/Greeting1 - "Hello"
        [HttpGet]
        [Route("api/RouteTest/Math/{operand1}/{operand2}")]
        public int Math(int operand1, int operand2)
        {
            return operand1*operand2;
        }


        //get: api/RouteTest/Greeting1
        [HttpGet]
        public string Greeting2()
        {
            return "Howdy";
        }



        //get: api/RouteTest/Greeting1
       
        public string Greeting3()
        {
            return "Heya";
        }


        //get: api/RouteTest/Greeting1

        public string Greeting4()
        {
            return "Hola";
        }






    }
}
