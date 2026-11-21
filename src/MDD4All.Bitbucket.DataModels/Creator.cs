using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Creator
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

}
