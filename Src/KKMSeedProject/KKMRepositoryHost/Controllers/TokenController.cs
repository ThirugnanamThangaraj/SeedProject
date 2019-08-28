using KKM.Repository.Common.Interface;
using KKM.Repository.Common.Model;
using KKM.Repository.Service;
using log4net;
using System.Net;
using System.Web.Http;

namespace KKM.Repository.Host.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/Token")]
    public class TokenController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(TokenController));
        private readonly LoginUserService _libraryService;
        public TokenController(ILoginUser loginUser)
        {
            Log.Info("LibraryController Started");
            _libraryService = new LoginUserService(loginUser);
        }

        [HttpPost]
               [AllowAnonymous]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

             var isCredentialValid = _libraryService.GetByName(login);
            if (isCredentialValid.IsValid)
            {
                var token = TokenGenerator.TokenGenerator.GenerateTokenJwt(login.Username);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
