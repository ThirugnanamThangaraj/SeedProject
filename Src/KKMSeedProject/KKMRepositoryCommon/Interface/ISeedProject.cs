using KKM.Repository.Common.Model;
using KKM.Repository.Common.Result;
using System.Collections.Generic;

namespace KKM.Repository.Common.Interface
{
    public interface ISeedProject
    {
        Result<List<User>> GetAll();
        Result<User> GetbyId(int id);
    }
}
