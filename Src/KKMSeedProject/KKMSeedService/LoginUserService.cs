using log4net;
using KKM.Repository.Common.Interface;
using KKM.Repository.Common.Model;
using KKM.Repository.Common.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM.Repository.Service
{
   public class LoginUserService
    {
        private readonly ILoginUser _loginUser;
        private static readonly ILog Log = LogManager.GetLogger(typeof(LoginUserService));
        public LoginUserService(ILoginUser loginUser)
        {
            Log.Info("SeedService");
            this._loginUser = loginUser;
        }


        public Result<LoginRequest> GetByName(LoginRequest loginRequest)
        {
            return this._loginUser.GetByName(loginRequest);
        }
    }
}
