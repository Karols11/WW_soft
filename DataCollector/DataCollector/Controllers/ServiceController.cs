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
        public bool AddItem(string Name)
        {
            DAL.Contexts.GenericContext<DAL.Models.KlasaK1> context = new DAL.Contexts.GenericContext<DAL.Models.KlasaK1>();
            return context.Add(new DAL.Models.KlasaK1 { Name = Name });   
       }
        [HttpPost]
        public IHttpActionResult  Test123(string pierwszy, string asd)
        {
            var a = new { Amount = pierwszy, Message = asd };
            return Ok(a);
        }
        
        public DAL.Models.KlasaK1 GetItem(int nrid)
        {
            DAL.Contexts.GenericContext<DAL.Models.KlasaK1> context = new DAL.Contexts.GenericContext<DAL.Models.KlasaK1>();
            return context.GetItemById(nrid);
        }
    }
}
