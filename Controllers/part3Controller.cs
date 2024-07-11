using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assign1.Controllers
{
    public class part3Controller : ApiController
    {
        // POST api/Greeting
        public IHttpActionResult Post()
        {
            string greetingMessage = "Hello World!";
            return Ok(greetingMessage);
        }
    }
}
