using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MaestriaController : ApiController
    {
        [HttpGet]
        [Route("api/montobecaMaestria")]
        public IHttpActionResult MontoBeca()
        {
            decimal monto = 6000;
            return Json(monto);
        }

        [HttpGet]
        [Route("api/listaMaestria")]
        public IHttpActionResult lstMaestria()
        {
            var objeto = 2;
            return Json(objeto);
        }
    }
}
