using System.Web.Http;

namespace Assign1.Controllers
{
    public class Part1Controller : ApiController
    {
        [HttpGet]
        [Route("api/AddTen/{id}")]
                                                    
        public IHttpActionResult AddTen(int id)
        {
            int result = id + 10;
            return Ok(result);
        }
    }
}
