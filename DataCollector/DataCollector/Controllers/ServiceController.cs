using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataCollector.Controllers
{
    public class ServiceController : ApiController
    {
        public IHttpActionResult Test()
        {
            return Ok("asd");
        }
        [HttpPost]
        //[Route("Index")]
        public int Index()
        {
            return 55;
        }
        [HttpPost]
        //[Route("Test123")]
        public IHttpActionResult  Test123(string pierwszy, string asd)
        {
            var a = new { Amount = pierwszy, Message = asd };
            return Ok(a);
        }
    }
}
