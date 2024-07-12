using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Avatar
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
