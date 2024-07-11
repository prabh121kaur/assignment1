using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assign1.Controllers
{
    public class part5Controller : ApiController
    {
        // GET api/NumberMachine/{id}
        public IHttpActionResult Get(int id)
        {
            // Perform four mathematical operations
            int addition = id + 10;  // Example operation, you can replace with your desired operation
            int subtraction = id - 5;  // Example operation, you can replace with your desired operation
            int multiplication = id * 2;  // Example operation, you can replace with your desired operation
            int division = id / 3;  // Example operation, you can replace with your desired operation

            // Construct response string
            string response = $"Input: {id}, Addition: {addition}, Subtraction: {subtraction}, Multiplication: {multiplication}, Division: {division}";

            return Ok(response);
        }
    }
}
