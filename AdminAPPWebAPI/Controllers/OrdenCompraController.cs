using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminAPPWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/OrdenCompra")]
    public class OrdenCompraController : Controller
    {
        // GET: api/OrdenCompra
        [HttpGet, Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OrdenCompra/5
        [HttpGet("{id}", Name = "Get"), Authorize]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/OrdenCompra
        [HttpPost, Authorize]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/OrdenCompra/5
        [HttpPut("{id}"), Authorize]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}"), Authorize]
        public void Delete(int id)
        {
        }
    }
}
