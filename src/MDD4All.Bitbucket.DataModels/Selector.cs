using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Selector
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
