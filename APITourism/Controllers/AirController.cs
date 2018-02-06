using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModel.Air;

namespace APITourism.Controllers
{
    public class AirController : ApiController
    {
        [AllowAnonymous]
        [HttpGet] //Recibir datos
        [Route("api/Air/getflights")]
        public IHttpActionResult Getflights(SearchFlights model)
        {
            string token = CrearSession.CrearSesion();
        }
    }
}
