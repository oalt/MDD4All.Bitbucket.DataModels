using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class State
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stage")]
        public Stage Stage { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }

}
