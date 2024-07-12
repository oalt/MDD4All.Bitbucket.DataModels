using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

}
