﻿using log4net;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KKM.Repository.Host.Controllers
{

    [AllowAnonymous]
    [RoutePrefix("api/Health")]
    public class HealthController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(HealthController));
        // GET: Health
        [System.Web.Http.AllowAnonymous]
        public HttpResponseMessage Get()
        {
            Log.Info("HealthController Get Invoked");
            return Request.CreateResponse(HttpStatusCode.OK, DateTime.UtcNow);
        }
    }
}