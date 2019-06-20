using Newtonsoft.Json;
using RandomUser.Utils;
using System;

namespace RandomUser.Model
{
    public class PictureInfo
    {
        [JsonProperty("medium")]
        [JsonConverter(typeof(UriConverter))]
        public Uri Medium { get; set; }

        [JsonProperty("large")]
        [JsonConverter(typeof(UriConverter))]
        public Uri Large { get; set; }

        [JsonProperty("thumbnail")]
        [JsonConverter(typeof(UriConverter))]
        public Uri Thumbnail { get; set; }
    }
}