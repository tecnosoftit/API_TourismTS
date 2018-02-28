using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services;
using ViewModel.General;
using System.Data;
using System.Web.Http.Description;
using Newtonsoft.Json.Linq;

namespace APITourism.Controllers
{
    [Route("api/cms/")]
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
        [Route("api/cms/getimagesbyid/" + "{id}")]
        public IHttpActionResult GetImagesById(int id)
        {
            var result = _cms.GetImagesById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimagesbyname/" + "{name}")]
        public IHttpActionResult GetImagesByName(string name)
        {
            return Ok(_cms.GetImagesByName(name));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postimagecreate")]
        public IHttpActionResult PostImageCreate([FromBody] Images value)
        {
            return Ok(_cms.PostImagesCreate(value.NAME_, value.DESCRIPTION_, value.STATUS_, value.CREATION,
                value.MODIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putimageupdate")]
        public IHttpActionResult PutImageUpdate([FromBody] Images value)
        {
            return Ok(_cms.PutImagesUpdate(value.IDENTIFICATION, value.NAME_, value.DESCRIPTION_, value.STATUS_,
                value.MODIFICATION));
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
        [Route("api/cms/getimageperplanbyima/" + "{Ima}")]
        public IHttpActionResult GetImagePerPlanByIma(int ima)
        {
            var result = _cms.GetImagePerPlanByIma(ima);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimageperplanbyname/" + "{name}")]
        public IHttpActionResult GetImagePerPlanByName(string name)
        {
            return Ok(_cms.GetImagePerPlanByName(name));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getimageperplanbypla/" + "{pla}")]
        public IHttpActionResult GetImagePerPlanByPla(int pla)
        {
            return Ok(_cms.GetImagePerPlanByPla(pla));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postimageperplancreate")]
        public IHttpActionResult PostImagePerPlanCreate([FromBody] ImagesPerPlan value)
        {
            return Ok(_cms.PostImagePerPlanCreate(value.IMAGE_IDENTIFICACION, value.PLAN_IDENTIFICATION));
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
        [Route("api/cms/getclasificationtypebyid/" + "{id}")]
        public IHttpActionResult GetClasificationTypeById(int id)
        {
            var result = _cms.GetClasificationTypeById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getclasificationtypebyname/" + "{name}")]
        public IHttpActionResult GetClasificationTypeByName(string name)
        {
            return Ok(_cms.GetClasificationTypeByName(name));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postclasificationtypecreate")]
        public IHttpActionResult PostClasificationTypeCreate([FromBody] ClasificationType value)
        {
            return Ok(_cms.PostClasificationTypeCreate(value.NAME_, value.DESCRIPTION_, value.STATUS_, value.CREATION,
                value.MODIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putclasificationtypeupdate")]
        public IHttpActionResult PutClasificationTypeUpdate([FromBody] ClasificationType value)
        {
            return Ok(_cms.PutClasificationTypeUpdate(value.IDENTIFICATION, value.NAME_, value.DESCRIPTION_,
                value.STATUS_, value.MODIFICATION));
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
        [Route("api/cms/getplandetailbyid/" + "{id}")]
        public IHttpActionResult GetPlanDetailById(int id)
        {
            var result = _cms.GetPlanDetailById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplandetailbyaco/" + "{aco}")]
        public IHttpActionResult GetPlanDetailByAco(int aco)
        {
            var result = _cms.GetPlanDetailByAco(aco);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postplandetailcreate")]
        public IHttpActionResult PostPlanDetailCreate([FromBody] PlanDetail value)
        {
            return Ok(_cms.PostPlanDetailCreate(value.PLAN_IDENTIFICATION, value.ACOMODATION_TYPE, value.PRICE,
                value.INCLUDED, value.NOT_INCLUDED, value.TEVELER_INFO, value.POLICIES, value.CONDITIONS,
                value.CREATION, value.MODIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putplandetailupdate")]
        public IHttpActionResult PutPlanDetailUpdate([FromBody] PlanDetail value)
        {
            return Ok(_cms.PutPlanDetailUpdate(value.IDENTIFICATION, value.PLAN_IDENTIFICATION, value.ACOMODATION_TYPE,
                value.PRICE, value.INCLUDED, value.NOT_INCLUDED, value.TEVELER_INFO, value.POLICIES, value.CONDITIONS,
                value.MODIFICATION));
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
        [Route("api/cms/getplanbyid/" + "{id}")]
        public IHttpActionResult GetPlanById(int id)
        {
            var result = _cms.GetPlanById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplanbyname/" + "{name}")]
        public IHttpActionResult GetPlanByName(string name)
        {
            return Ok(_cms.GetPlanByName(name));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postplancreate")]
        public IHttpActionResult PostPlanCreate([FromBody] Plans value)
        {
            return Ok(_cms.PostPlanCreate(value.NAMES, value.DESCRIPTIONS, value.STATUS_, value.TYPE_, value.CREATION,
                value.MODIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putplanupdate")]
        public IHttpActionResult PutPlanUpdate([FromBody] Plans value)
        {
            return Ok(_cms.PutPlanUpdate(value.IDENTIFICATION, value.NAMES, value.DESCRIPTIONS, value.STATUS_,
                value.TYPE_, value.MODIFICATION));
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
        [Route("api/cms/gettypebyid/" + "{id}")]
        public IHttpActionResult GetTypeById(int id)
        {
            var result = _cms.GetTypeById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/gettypebyname/" + "{name}")]
        public IHttpActionResult GetTypeByName(string name)
        {
            return Ok(_cms.GetTypeByName(name));
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/posttypecreate")]
        public IHttpActionResult PostTypeCreate([FromBody] Types value)
        {
            return Ok(_cms.PostTypeCreate(value.NAMES, value.DESCRIPTIONS, value.IMAGE_URL, value.TYPE_CLASIFICATION,
                value.STATUS_, value.CREATION, value.MODIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/puttypeupdate")]
        public IHttpActionResult PutTypeUpdate([FromBody] Types value)
        {
            return Ok(_cms.PutTypeUpdate(value.IDENTIFICATION, value.NAMES, value.DESCRIPTIONS, value.IMAGE_URL,
                value.TYPE_CLASIFICATION, value.STATUS_, value.MODIFICATION));
        }

        //CRUD CitesxPlan

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitesxplan")]
        public IHttpActionResult GetCitesxPlan()
        {
            return Ok(_cms.GetCitesxPlan());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitesxplanbyid/" + "{id}")]
        public IHttpActionResult GetCitesxPlanById(int id)
        {
            var result = _cms.GetCitesxPlanById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitesxplanbyname/" + "{name}")]
        public IHttpActionResult GetCitesxPlanByName(string name)
        {
            return Ok(_cms.GetCitesxPlanByName(name));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitesxplanbypla/" + "{plan}")]
        public IHttpActionResult GetCitesxPlanByPla(string plan)
        {
            return Ok(_cms.GetCitesxPlanByPla(plan));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitesxplanbycit/" + "{id}")]
        public IHttpActionResult GetCitesxPlanByCit(int id)
        {
            var result = _cms.GetCitesxPlanByCit(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postcitesxplancreate")]
        public IHttpActionResult PostCitesxPlanCreate([FromBody] CitesxPlan value)
        {
            return Ok(_cms.PostCitesxPlanCreate(value.CITY_IDENTIFICATION, value.PLAN_IDENTIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putcitesxplanupdate")]
        public IHttpActionResult PutCitesxPlanUpdate([FromBody] CitesxPlan value)
        {
            return Ok(_cms.PutCitesxPlanUpdate(value.IDENTIFICATION, value.CITY_IDENTIFICATION,
                value.PLAN_IDENTIFICATION));
        }

        //CRUD City

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcity")]
        public IHttpActionResult GetCity()
        {
            return Ok(_cms.GetCity());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitybyid/" + "{id}")]
        public IHttpActionResult GetCityById(int id)
        {
            var result = _cms.GetCityById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitybyname/" + "{name}")]
        public IHttpActionResult GetCityByName(string name)
        {
            return Ok(_cms.GetCityByName(name));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcitybysta/" + "{id}")]
        public IHttpActionResult GetCityBySta(int id)
        {
            var result = _cms.GetCityBySta(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postcitycreate")]
        public IHttpActionResult PostCityCreate([FromBody] City value)
        {
            return Ok(_cms.PostCityCreate(value.NAME_, value.LOCALITED, value.LATITUDED, value.STATE_IDENTIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putcityupdate")]
        public IHttpActionResult PutCityUpdate([FromBody] City value)
        {
            return Ok(_cms.PutCityUpdate(value.IDENTIFICATION, value.NAME_, value.LOCALITED, value.LATITUDED,
                value.STATE_IDENTIFICATION));
        }

        //CRUD Company

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompany")]
        public IHttpActionResult GetCompany()
        {
            return Ok(_cms.GetCompany());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompanybyid/" + "{id}")]
        public IHttpActionResult GetCompanyById(string id)
        {
            var result = _cms.GetCompanyById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompanybyname/" + "{name}")]
        public IHttpActionResult GetCompanyByName(string name)
        {
            return Ok(_cms.GetCompanyByName(name));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompanybynit/" + "{nit}")]
        public IHttpActionResult GetCompanyByNit(string nit)
        {
            return Ok(_cms.GetCompanyByNit(nit));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postcompanycreate")]
        public IHttpActionResult PostCompanyCreate([FromBody] Company value)
        {
            return Ok(_cms.PostCompanyCreate(value.NAME_, value.DESCRIPTION_, value.NIT));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putcompanyupdate")]
        public IHttpActionResult PutCompanyUpdate([FromBody] Company value)
        {
            return Ok(_cms.PutCompanyUpdate(value.IDENTIFICATION, value.NAME_, value.DESCRIPTION_, value.NIT));
        }

        //CRUD CompanyProperties

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompanyproperties")]
        public IHttpActionResult GetCompanyProperties()
        {
            return Ok(_cms.GetCompanyProperties());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompanypropertiesbyid/" + "{id}")]
        public IHttpActionResult GetCompanyPropertiesById(int id)
        {
            var result = _cms.GetCompanyPropertiesById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompanypropertiesbykey/" + "{key}")]
        public IHttpActionResult GetCompanyPropertiesByKey(string key)
        {
            return Ok(_cms.GetCompanyPropertiesByKey(key));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcompanypropertiesbycom/" + "{com}")]
        public IHttpActionResult GetCompanyPropertiesByCom(string com)
        {
            return Ok(_cms.GetCompanyPropertiesByCom(com));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postcompanypropertiescreate")]
        public IHttpActionResult PostCompanyPropertiesCreate([FromBody] CompanyProperties value)
        {
            return Ok(_cms.PostCompanyPropertiesCreate(value.KEY_, value.VALUE_, value.COMPANY_IDENTIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putcompanypropertiesupdate")]
        public IHttpActionResult PutCompanyPropertiesUpdate([FromBody] CompanyProperties value)
        {
            return Ok(_cms.PutCompanyPropertiesUpdate(value.IDENTIFICATION, value.KEY_, value.VALUE_,
                value.COMPANY_IDENTIFICATION));
        }

        //CRUD Country

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcountry")]
        public IHttpActionResult GetCountry()
        {
            return Ok(_cms.GetCountry());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcountrybyid/" + "{id}")]
        public IHttpActionResult GetCountryById(int id)
        {
            var result = _cms.GetCountryById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getcountrybyname/" + "{name}")]
        public IHttpActionResult GetCountryByName(string name)
        {
            return Ok(_cms.GetCountryByName(name));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postcountrycreate")]
        public IHttpActionResult PostCountryCreate([FromBody] Country value)
        {
            return Ok(_cms.PostCountryCreate(value.COUNTRY));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putcountryupdate")]
        public IHttpActionResult PutCountryUpdate([FromBody] Country value)
        {
            return Ok(_cms.PutCountryUpdate(value.IDENTIFICATION, value.COUNTRY));
        }

        //CRUD PlansxCompany

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplansxcompany")]
        public IHttpActionResult GetPlansxCompany()
        {
            return Ok(_cms.GetPlansxCompany());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplansxcompanybyid/" + "{id}")]
        public IHttpActionResult GetPlansxCompanyById(int id)
        {
            var result = _cms.GetPlansxCompanyById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplansxcompanybyname/" + "{name}")]
        public IHttpActionResult GetPlansxCompanyByName(string name)
        {
            return Ok(_cms.GetPlansxCompanyByName(name));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplansxcompanybyplan/" + "{plan}")]
        public IHttpActionResult GetPlansxCompanyByPlan(string plan)
        {
            return Ok(_cms.GetPlansxCompanyByPlan(plan));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getplansxcompanybycom/" + "{com}")]
        public IHttpActionResult GetPlansxCompanyByCom(string com)
        {
            return Ok(_cms.GetPlansxCompanyByCom(com));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postplansxcompanycreate")]
        public IHttpActionResult PostPlansxCompanyCreate([FromBody] PlansxCompany value)
        {
            return Ok(_cms.PostPlansxCompanyCreate(value.PLAN_IDENTIFICATION, value.COMPANY_IDENTIFICATION,
                value.PARENT_IDENTIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putplansxcompanyupdate")]
        public IHttpActionResult PutPlansxCompanyUpdate([FromBody] PlansxCompany value)
        {
            return Ok(_cms.PutPlansxCompanyUpdate(value.IDENTIFICATION, value.PLAN_IDENTIFICATION,
                value.COMPANY_IDENTIFICATION, value.PARENT_IDENTIFICATION));
        }

        //CRUD PropertiesxUser

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getpropertiesxuser")]
        public IHttpActionResult GetPropertiesxUser()
        {
            return Ok(_cms.GetPropertiesxUser());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getpropertiesxuserbyuser/" + "{user}")]
        public IHttpActionResult GetPropertiesxUserByUser(string user)
        {
            var result = _cms.GetPropertiesxUserByUser(user);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getpropertiesxuserbyemail/" + "{email}")]
        public IHttpActionResult GetPropertiesxUserByEmail(string email)
        {
            return Ok(_cms.GetPropertiesxUserByEmail(email));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postpropertiesxusercreate")]
        public IHttpActionResult PostPropertiesxUserCreate([FromBody] PropertiesxUser value)
        {
            return Ok(_cms.PostPropertiesxUserCreate(value.USER_IDENTIFICATION, value.COMPANY_IDENTIFICATION,
                value.EMAIL, value.PASSWORD_));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putpropertiesxuserupdate")]
        public IHttpActionResult PutPropertiesxUserUpdate([FromBody] PropertiesxUser value)
        {
            return Ok(_cms.PutPropertiesxUserUpdate(value.IDENTIFICATION, value.USER_IDENTIFICATION,
                value.COMPANY_IDENTIFICATION, value.EMAIL, value.PASSWORD_));
        }

        //CRUD Role

        [Authorize(Roles = "SUPERADMIN, SITEADMIN")]
        [HttpGet]
        [Route("api/cms/getrole")]
        public IHttpActionResult GetRole()
        {
            return Ok(_cms.GetRole());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getrolebyid/" + "{id}")]
        public IHttpActionResult GetRoleById(int id)
        {
            var result = _cms.GetRoleById(id);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getrolebyname/" + "{name}")]
        public IHttpActionResult GetRoleByName(string name)
        {
            return Ok(_cms.GetRoleByName(name));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postrolecreate")]
        public IHttpActionResult PostRoleCreate([FromBody] Role value)
        {
            return Ok(_cms.PostRoleCreate(value.NAME_, value.STATUS_));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putroleupdate")]
        public IHttpActionResult PutRoleUpdate([FromBody] Role value)
        {
            return Ok(_cms.PutRoleUpdate(value.IDENTIFICATION, value.NAME_, value.STATUS_));
        }

        //CRUD State

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getstate")]
        public IHttpActionResult GetState()
        {
            return Ok(_cms.GetState());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getstatebycou/" + "{country}")]
        public IHttpActionResult GetStateByCou(int country)
        {
            var result = _cms.GetStateByCou(country);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getstatebyname/" + "{name}")]
        public IHttpActionResult GetStateByName(string name)
        {
            return Ok(_cms.GetStateByName(name));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/poststatecreate")]
        public IHttpActionResult PostStateCreate([FromBody] State value)
        {
            return Ok(_cms.PostStateCreate(value.NAME_, value.COUNTRY_IDENTIFICATION));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putstateupdate")]
        public IHttpActionResult PutStateUpdate([FromBody] State value)
        {
            return Ok(_cms.PutStateUpdate(value.IDENTIFICATION, value.NAME_, value.COUNTRY_IDENTIFICATION));
        }

        //CRUD Users

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getusers")]
        public IHttpActionResult GetUsers()
        {
            return Ok(_cms.GetUsers());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getusersbyname/" + "{name}")]
        public IHttpActionResult GetUsersByName(string name)
        {
            return Ok(_cms.GetUsersByName(name));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postuserscreate")]
        public IHttpActionResult PostUsersCreate([FromBody] Users value)
        {
            return Ok(_cms.PostUsersCreate(value.NAME_, value.SURNAME, value.PHONE, value.BIRTHDAY, value.STATUS_));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("api/cms/putusersupdate")]
        public IHttpActionResult PutStateUpdate([FromBody] Users value)
        {
            return Ok(_cms.PutUsersUpdate(value.IDENTIFICATION, value.NAME_, value.SURNAME, value.PHONE, value.BIRTHDAY,
                value.STATUS_));
        }

        //[Authorize(Roles = "SUPERADMIN, SITEADMIN")]
        [AllowAnonymous]
        [HttpPost]
        [Route("api/cms/postmenucreate")]
        public IHttpActionResult PostMenuCreate(Menu value)
        {
            return Ok(_cms.PostMenuCreate(value));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/cms/getmenu/" +"{id}")]
        public IHttpActionResult GetMenu(int id)
        {
            return Ok(_cms.GetMenu(id));
        }
    }
}


