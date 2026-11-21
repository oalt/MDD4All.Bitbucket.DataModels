using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Commit
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }

}
