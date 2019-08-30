using KKM.Repository.Common.Interface;
using KKM.Repository.Common.Model;
using KKM.Repository.Common.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM.Repository.Repository
{
    public class LoginUser : ILoginUser
    {
       public Result<LoginRequest> GetByName(LoginRequest loginRequest)
        {
           var result = GetUser().Where(x => x.Username.Equals(loginRequest.Username) &&  x.Password.Equals(loginRequest.Password)).Select(x => x).FirstOrDefault();
            if (result != null)
            { return new Result<LoginRequest>(true, result, "Success"); }
            else
            {
                return new Result<LoginRequest>(false, result, "No Record..");
            }
        }

        private List<LoginRequest> GetUser()
        {
            List<LoginRequest> users = new List<LoginRequest>();
            for (int i = 1; i <= 3; i++)
            {
                users.Add(new LoginRequest { Username = "SSM" + i ,Password="123456"});
            }


            return users;
        }
    }
}
