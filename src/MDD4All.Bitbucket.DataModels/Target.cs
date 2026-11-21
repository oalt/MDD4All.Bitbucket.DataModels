using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Target
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ref_type")]
        public string RefType { get; set; }

        [JsonProperty("ref_name")]
        public string RefName { get; set; }

        [JsonProperty("selector")]
        public Selector Selector { get; set; }

        [JsonProperty("commit")]
        public Commit Commit { get; set; }
    }

}
