using Newtonsoft.Json;

namespace MDD4All.Bitbucket.DataModels
{
    public class Links
    {
        [JsonProperty("self")]
        public Self Self { get; set; }

        [JsonProperty("html")]
        public Html Html { get; set; }

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }

        [JsonProperty("steps")]
        public Steps Steps { get; set; }
    }

}
