﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using Newtonsoft.Json;
using ViewModel.General;

namespace APITourism.Controllers
{
    [Route("api/account/")]
    public class AccountController : ApiController
    {
        [Authorize]
        [HttpGet]
        [Route("api/account/GetUserDeatil")]
        public IHttpActionResult GetUserDeatil()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var usr = identity.Claims.Where(x => x.Type.Equals("UserInfo")).Select(c => c.Value).FirstOrDefault();
            return Ok(JsonConvert.DeserializeObject<User>(usr));
        }
    }
}
