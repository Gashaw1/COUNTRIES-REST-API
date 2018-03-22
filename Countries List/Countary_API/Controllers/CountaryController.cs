using ContinentsBLO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Countary_API.Controllers
{
    public class CountaryController : ApiController
    {
        public HttpResponseMessage GetCountary()
        {
            var result = Cotinent.continteniesRturn();
            return ControllerContext.Request.CreateResponse(HttpStatusCode.OK, new { result });
        }
    }
}
