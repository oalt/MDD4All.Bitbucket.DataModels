using Newtonsoft.Json;
using System.Collections.Generic;

namespace MDD4All.Bitbucket.DataModels
{
    public class PipelineDataResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagelen")]
        public int Pagelen { get; set; }

        [JsonProperty("values")]
        public List<Value> Values { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

}
