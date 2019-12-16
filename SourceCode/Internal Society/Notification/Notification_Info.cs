using Newtonsoft.Json;
using System.Collections.Generic;

namespace Internal_Society
{

    public class List_Notification
    {
        public List<Notification_Info> data { get; set; }
        public bool success { get; set; }
    }

    public class Notification_Info
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("sender")]
        public string sender { get; set; }

        [JsonProperty("sender_fullname")]
        public string sender_fullname { get; set; }

        [JsonProperty("receiver")]
        public string receiver { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("detail")]
        public string detail { get; set; }
    }
}
