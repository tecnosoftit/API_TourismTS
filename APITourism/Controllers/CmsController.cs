using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services;
using ViewModel.General;
using System.Data;

namespace APITourism.Controllers
{
    public class CmsController : ApiController
    {
        private readonly Cms _cms = new Cms();

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimages")]
        public IHttpActionResult GetImages()
        {            
            return Ok(_cms.GetImages());
        }
        [AllowAnonymous]
        [HttpGet] //Recibir datos
        [Route("api/cms/getimages")]
        public IHttpActionResult GetClasificationType()
        {
            return Ok(_cms.GetClasificationType());
        }

        [HttpPost] //Enviar datos
        [Route("api/cms/postcreateimage")]
        public IHttpActionResult CreateImage()
        {
            var datecre = DateTime.Parse("2018-01-01 13:01:02");
            var datemod = DateTime.Parse("2018-01-30 10:01:58");
            return Ok(_cms.SetImages("Logo1","Imagen principal",false,datecre,datemod));
        }
             
    }

    
}
