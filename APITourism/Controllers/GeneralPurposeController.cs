using System.Web.Http;
using Services;
using ViewModel.General;

namespace APITourism.Controllers
{
    public class GeneralPurposeController : ApiController
    {
        private readonly Cms _cms = new Cms();

        [AllowAnonymous]
        [HttpPost]
        [Route("api/generalpurpose/getcompanyinformation/")]
        public IHttpActionResult GetCompanyInformation(CompanyPropertiesRq company)
        {
            return Ok(_cms.GetCompanyInformation(company.Url));
        }
    }
}
