using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assign1.Controllers
{
    public class part6Controller : ApiController
    {
        // GET api/HostingCost/{id}
        public IHttpActionResult Get(int id)
        {
            // Calculate the number of fortnights
            int fortnights = (id + 13) / 14; // Adding 13 days to ensure we round up

            // Calculate the total cost of hosting
            double hostingCost = fortnights * 5.50;

            // Calculate the HST (Harmonized Sales Tax)
            double hst = hostingCost * 0.13;

            // Calculate the total cost including HST
            double totalCost = hostingCost + hst;

            // Construct response strings
            string costString = $"{fortnights} fortnights at $5.50/FN = ${hostingCost:F2} CAD";
            string hstString = $"HST 13% = ${hst:F2} CAD";
            string totalString = $"Total = ${totalCost:F2} CAD";

            // Return the response strings
            return Ok(new string[] { costString, hstString, totalString });
        }
    }
}
