using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class PregradoController : ApiController
    {
        [HttpGet]
        [Route("api/montobecaPregrado")]
        public IHttpActionResult MontoBeca()
        {
            decimal monto = 7000;
            return Json(monto);
        }

        [HttpGet]
        [Route("api/listaPregrado")]
        public IHttpActionResult lstPregrado()
        {
            var objeto = 2;
            return Json(objeto);
        }
    }
}
