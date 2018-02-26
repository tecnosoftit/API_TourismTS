using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using Newtonsoft.Json;
using Services;
using ViewModel.General;

namespace APITourism.Controllers
{
    [Route("api/account/")]
    public class AccountController : ApiController
    {
        private readonly Cms _cms = new Cms();

        [Authorize]
        [HttpGet]
        [Route("api/account/GetUserDeatil")]
        public IHttpActionResult GetUserDeatil()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var usr = identity.Claims.Where(x => x.Type.Equals("UserInfo")).Select(c => c.Value).FirstOrDefault();
            return Ok(JsonConvert.DeserializeObject<User>(usr));
        }

        [Authorize]
        [HttpGet]
        [Route("api/account/GetUserMenu")]
        public IHttpActionResult GetUserMenu()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var usr = identity.Claims.Where(x => x.Type.Equals("Menu")).Select(c => c.Value).FirstOrDefault();
            return Ok(JsonConvert.DeserializeObject<List<Menu>>(usr));
        }

        [Authorize]
        [HttpGet]
        [Route("api/account/IsLogged")]
        public IHttpActionResult IsLogged()
        {
            return Ok(true);
        }

        [Authorize(Roles = "SUPERADMIN")]
        [HttpPost]
        [Route("api/account/CreateUser")]
        public IHttpActionResult CreateUser(CreateUser usr)
        {
            return Ok(_cms.CreateUser(usr));
        }
    }
}
