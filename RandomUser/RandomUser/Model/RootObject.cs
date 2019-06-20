using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Model
{
    public class RootObject
    {

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<User> Users { get; set; }
    }
}
