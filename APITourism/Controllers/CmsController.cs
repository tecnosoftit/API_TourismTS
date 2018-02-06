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
            return Ok(_cms.PostImagesCreate("Logo1","Imagen principal",false,datecre,datemod));
        }

        [AllowAnonymous]
        [HttpPut] 
        [Route("api/cms/putimageupdate")]
        public IHttpActionResult PutImageUpdate()
        {
            var datemod = DateTime.Parse("2018-02-03 11:20:58");
            return Ok(_cms.PutImagesUpdate(9,"Logo2", "Imagen Favicon", true, datemod));
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
        [Route("api/cms/getimageperplanbyname")] //Averiguar como traigo datos del inner join
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
            return Ok(_cms.PutClasificationTypeUpdate(3, "Daniel", "Primo de Omar", false, datemod));
        }
    }

    
}
