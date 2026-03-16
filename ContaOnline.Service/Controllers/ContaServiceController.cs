using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContaOnline.Service.Controllers
{
    public class ContaServiceController : ApiController
    {
        // GET: api/ContaService
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
