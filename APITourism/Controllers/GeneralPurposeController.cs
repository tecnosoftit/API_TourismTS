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
    public enum StringSearchOption
    {
        StartsWith,
        Contains,
        EndsWith
    }
    [Route("api/generalpurpose/")]
    public class GeneralPurposeController : ApiController
    {
        private readonly Cms _cms = new Cms();

        [AllowAnonymous]
        [HttpGet]
        [Route("api/generalpurpose/getcompanyinformation/" + "{url}")]
        public IHttpActionResult GetCompanyInformation(string url)
        {
            var company = "ariesik";
            List<dynamic> Information = new List<dynamic>();
            var cpInfo = _cms.GetCompanyInformation(company);            
            return Ok("");
        }
    }
}
