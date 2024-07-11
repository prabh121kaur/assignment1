using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assign1.Controllers
{
    public class part4Controller : ApiController
    {
        // GET api/Greeting/{id}
        public IHttpActionResult Get(int id)
        {
            string greetingMessage = $"Greetings to {id} people!";
            return Ok(greetingMessage);
        }
    }
}
