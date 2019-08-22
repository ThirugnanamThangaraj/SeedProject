using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM.Repository.Common.Model
{
    public class LoginRequest
    {
        [JsonProperty]
        public string Username { get; set; }
        [JsonProperty]
        public string Password { get; set; }
    }
}
