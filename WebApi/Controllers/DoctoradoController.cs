using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DoctoradoController : ApiController
    {
        [HttpGet]
        [Route("api/montobecaDoctorado")]
        public IHttpActionResult MontoBeca()
        {
            decimal monto = 5000;
            return Json(monto);
        }

        [HttpGet]
        [Route("api/listaDoctorado")]
        public IHttpActionResult lstDoctorado()
        {
            var objeto = 2;     
            return Json(objeto);
        }
    }
}
