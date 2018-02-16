using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModel.General;
using Services;
using System.Collections;
using System.Dynamic;
using System.IO;
using System.Reflection;

namespace APITourism.Controllers
{
    public class GeneralPurposeController : ApiController
    {
        private readonly Cms _cms = new Cms();

        [AllowAnonymous]
        [HttpGet]
        [Route("api/generalpurpose/getcompanyinformation/" + "{url}")]
        public IHttpActionResult GetCompanyInformation(string url)
        {
            return Ok(_cms.GetCompanyInformation(url));
        }
    }
}
