using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assign1.Controllers
{
    public class part2Controller : ApiController
    {
        // GET api/Square/{id}
        public IHttpActionResult Get(int id)
        {
            int square = id * id;
            return Ok(square);
        }
    }
}

