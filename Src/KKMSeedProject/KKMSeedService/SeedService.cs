using log4net;
using KKM.Repository.Common.Interface;
using KKM.Repository.Common.Model;
using KKM.Repository.Common.Result;
using System.Collections.Generic;

namespace KKM.Repository.Service
{
    public class SeedService
    {
        private readonly ISeedProject _seedProject;
        private static readonly ILog Log = LogManager.GetLogger(typeof(SeedService));
        public SeedService(ISeedProject seedProject)
        {
            Log.Info("SeedService");
            this._seedProject = seedProject;
        }

        public Result<List<User>> GetAll()
        {
           return this._seedProject.GetAll();
        }

        public Result<User> GetbyId(int id)
        {
            return this._seedProject.GetbyId(id);
        }

    }
}
