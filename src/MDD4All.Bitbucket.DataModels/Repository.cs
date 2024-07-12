using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Repository
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

}
