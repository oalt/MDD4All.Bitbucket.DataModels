using Newtonsoft.Json;
using System;

namespace MDD4All.Bitbucket.DataModels
{
    public class Value
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }

        [JsonProperty("state")]
        public State State { get; set; }

        [JsonProperty("build_number")]
        public int BuildNumber { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }

        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("target")]
        public Target Target { get; set; }

        [JsonProperty("trigger")]
        public Trigger Trigger { get; set; }

        [JsonProperty("run_number")]
        public int RunNumber { get; set; }

        [JsonProperty("duration_in_seconds")]
        public int DurationInSeconds { get; set; }

        [JsonProperty("build_seconds_used")]
        public int BuildSecondsUsed { get; set; }

        [JsonProperty("first_successful")]
        public bool FirstSuccessful { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("has_variables")]
        public bool HasVariables { get; set; }

        [JsonProperty("completed_on")]
        public DateTime? CompletedOn { get; set; }
    }

}
