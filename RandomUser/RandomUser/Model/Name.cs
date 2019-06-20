using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Model
{
  public  class Name
    {

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonIgnore] public string NombreCompleto { get => Title=" "+ First + " " + Last; }

    }
}
