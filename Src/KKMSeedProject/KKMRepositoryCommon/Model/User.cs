using Newtonsoft.Json;

namespace KKM.Repository.Common.Model
{
    public class User
    {
        [JsonProperty]
        public int UserId { get; set; }

        [JsonProperty]
        public string Username { get; set; }

        [JsonProperty]
        public string EmailId { get; set; }

        [JsonProperty]
        public string MobileNo { get; set; }
    }
}
