using KKM.Repository.Common.Interface;
using KKM.Repository.Common.Model;
using KKM.Repository.Common.Result;
using System.Collections.Generic;
using System.Linq;

namespace KKM.Repository.Repository
{
    public  class SeedProject: ISeedProject
    {
       public Result<List<User>> GetAll()
        {
            
            return new Result<List<User>>(true, getUser(), "Success");
            
        }

        public Result<User> GetbyId(int id)
        {

            User result = getUser().Where(x => x.UserId.Equals(id)).Select(x=>x).FirstOrDefault();


            return new Result<User>(true, result, "Success");
        }
       



        private List<User> getUser()
        {
            List<User> users = new List<User>();
            for (int i = 1; i <= 100; i++)
            {
                users.Add(new User { UserId = i, Username = "Smith"+i, EmailId = "thirugnanammca"+i+"@gmail.com", MobileNo = "+919597212436" });
            }
            
           
            return users;
        }

    }
}
