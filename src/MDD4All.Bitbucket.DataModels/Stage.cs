using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Stage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
