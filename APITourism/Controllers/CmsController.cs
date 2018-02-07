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

        //CRUD Images

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimages")]
        public IHttpActionResult GetImages()
        {
            return Ok(_cms.GetImages());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimagesbyid")]
        public IHttpActionResult GetImagesById()
        {
            var result = _cms.GetImagesById(1);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimagesbyname")]
        public IHttpActionResult GetImagesByName()
        {
            return Ok(_cms.GetImagesByName("L"));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postimagecreate")]
        public IHttpActionResult PostImageCreate()
        {
            var datecre = DateTime.Parse("2018-01-01 13:01:02");
            var datemod = DateTime.Parse("2018-01-30 10:01:58");
            return Ok(_cms.PostImagesCreate("Logo1", "Imagen principal", false, datecre, datemod));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putimageupdate")]
        public IHttpActionResult PutImageUpdate()
        {
            var datemod = DateTime.Parse("2018-02-03 11:20:58");
            return Ok(_cms.PutImagesUpdate(9, "Logo2", "Imagen Favicon", true, datemod));
        }

        //CRUD ImagesPerplan

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimageperplan")]
        public IHttpActionResult GetImagePerPlan()
        {
            return Ok(_cms.GetImagePerPlan());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimageperplanbyima")]
        public IHttpActionResult GetImagePerPlanByIma()
        {
            var result = _cms.GetImagePerPlanByIma(1);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimageperplanbyname")] 
        public IHttpActionResult GetImagePerPlanByName()
        {
            return Ok(_cms.GetImagePerPlanByName("L"));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimageperplanbypla")]
        public IHttpActionResult GetImagePerPlanByPla()
        {
            return Ok(_cms.GetImagePerPlanByPla(2));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postimageperplancreate")]
        public IHttpActionResult PostImagePerPlanCreate()
        {
            return Ok(_cms.PostImagePerPlanCreate(3,3));
        }

        //CRUD ClasificationType

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getclasificationtype")]
        public IHttpActionResult GetClasificationType()
        {
            return Ok(_cms.GetClasificationType());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getclasificationtypebyid")]
        public IHttpActionResult GetClasificationTypeById()
        {
            var result = _cms.GetClasificationTypeById(5);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getclasificationtypebyname")]
        public IHttpActionResult GetClasificationTypeByName()
        {
            return Ok(_cms.GetClasificationTypeByName("P"));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postclasificationtypecreate")]
        public IHttpActionResult PostClasificationTypeCreate()
        {
            var datecre = DateTime.Parse("2018-01-01 13:01:02");
            var datemod = DateTime.Parse("2018-01-30 10:01:58");
            return Ok(_cms.PostClasificationTypeCreate("Jeisson", "Gordito Tierno", true, datecre, datemod));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putclasificationtypeupdate")]
        public IHttpActionResult PutClasificationTypeUpdate()
        {
            var datemod = DateTime.Parse("2018-02-03 11:20:58");
            return Ok(_cms.PutClasificationTypeUpdate(3, "Daniel", "Primo de Omaira", false, datemod));
        }

        //CRUD PlanDetail

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplandetail")]
        public IHttpActionResult GetPlanDetail()
        {
            return Ok(_cms.GetPlanDetail());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplandetailbyid")]
        public IHttpActionResult GetPlanDetailById()
        {
            var result = _cms.GetPlanDetailById(8);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postplandetailcreate")]
        public IHttpActionResult PostPlanDetailCreate()
        {
            var datecre = DateTime.Parse("2018-01-01 13:01:02");
            var datemod = DateTime.Parse("2018-01-30 10:01:58");
            return Ok(_cms.PostPlanDetailCreate(2, 6, "730000", "Piscina-Minibar", "Wifi", "Jum, sabra Dios", "Lero", "Lero", datecre, datemod));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putplandetailupdate")] //Revisar porque no actualiza
        public IHttpActionResult PutPlanDetailUpdate()
        {
            var datemod = DateTime.Parse("2018-02-06 14:47:50");
            return Ok(_cms.PutPlanDetailUpdate(8, 1, 6, "750000", "Piscina-Wifi-Parqueadero Doble", "Mini bar-Toboganes", "Ni puerca vida que es esto", "Cheverongo", "Ninguna", datemod));
        }

        //CRUD Plans

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplan")]
        public IHttpActionResult GetPlan()
        {
            return Ok(_cms.GetPlan());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplanbyid")]
        public IHttpActionResult GetPlanById()
        {
            var result = _cms.GetPlanById(4);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplanbyname")]
        public IHttpActionResult GetPlanByName()
        {
            return Ok(_cms.GetPlanByName("C"));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postplancreate")]
        public IHttpActionResult PostPlanCreate()
        {
            var datecre = DateTime.Parse("2018-01-01 13:01:02");
            var datemod = DateTime.Parse("2018-01-30 10:01:58");
            return Ok(_cms.PostPlanCreate("Vacaciones", "Vacaciones de Octubre", true, 2, datecre, datemod));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putplanupdate")]
        public IHttpActionResult PutPlanUpdate()
        {
            var datemod = DateTime.Parse("2018-02-03 11:20:58");
            return Ok(_cms.PutPlanUpdate(1, "Planzasazo", "Super Wow!", true, 1, datemod));
        }

        //CRUD Types

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/gettypes")]
        public IHttpActionResult GetTypes()
        {
            return Ok(_cms.GetTypes());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/gettypebyid")]
        public IHttpActionResult GetTypeById()
        {
            var result = _cms.GetTypeById(7);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/gettypebyname")]
        public IHttpActionResult GetTypeByName()
        {
            return Ok(_cms.GetTypeByName("N"));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/posttypecreate")]
        public IHttpActionResult PostTypeCreate()
        {
            var datecre = DateTime.Parse("2018-02-07 13:01:02");
            var datemod = DateTime.Parse("2018-02-07 10:01:58");
            return Ok(_cms.PostTypeCreate("Cambio", "Cambio prueba", "www.prueba.com.co", 3, true, datecre, datemod));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/puttypeupdate")]
        public IHttpActionResult PutTypeUpdate()
        {
            var datemod = DateTime.Parse("2018-02-07 11:20:58");
            return Ok(_cms.PutTypeUpdate(4, "Neron1", "Nombresito", "www.neron.com.co", 2, true, datemod));
        }
    }


}
