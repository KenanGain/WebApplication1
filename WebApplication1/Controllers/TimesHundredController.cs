using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TimesHundredController : ApiController
    {
        //api/TimesHundred/90 -> 9000
        public int Get(int id)
        {
            return id * 100;
        }
        //POST : api/TimesFifty/5 -> 250
        public int Post(int id) 
        {

            return id * 50;
        }


    }
}
