using log4net;
using KKM.Repository.Common.Interface;
using KKM.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KKM.Repository.Service;

namespace KKM.Repository.Host.Controllers
{

    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserController));

        private readonly SeedService _libraryService;
        public UserController(ISeedProject _seedProject)
        {
            log.Info("LibraryController Started");
            _libraryService = new SeedService(_seedProject);
        }


        public HttpResponseMessage GetAll()
        {
              var response = _libraryService.GetAll();
            if (!response.IsValid)
            {
                log.Info($"api/user/GetAll failed - {response.ErrorMessage}");
                return Request.CreateResponse(HttpStatusCode.BadRequest, $"{response.ErrorMessage}");
            }
            else
                return Request.CreateResponse(HttpStatusCode.OK, response.Value);
        }

        public HttpResponseMessage GetbyId(int id)
        {
            var response = _libraryService.GetbyId(id);
            if (!response.IsValid)
            {
                log.Info($"api/user/GetAll failed - {response.ErrorMessage}");
                return Request.CreateResponse(HttpStatusCode.BadRequest, $"{response.ErrorMessage}");
            }
            else
                return Request.CreateResponse(HttpStatusCode.OK, response.Value);
        }
    }
}
