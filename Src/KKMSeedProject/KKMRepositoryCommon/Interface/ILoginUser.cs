using KKM.Repository.Common.Model;
using KKM.Repository.Common.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM.Repository.Common.Interface
{
   public interface ILoginUser
    {

        Result<LoginRequest> GetByName(LoginRequest loginRequest);
    }
}
