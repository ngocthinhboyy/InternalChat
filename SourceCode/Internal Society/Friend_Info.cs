using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Society
{   // dữ liệu của other users
    public class Friend_Info
    {
        [JsonProperty("friend_ID")]
        public string friend_ID { get; set; }

        [JsonProperty("friend_Username")]
        public string friend_Username { get; set; }

        [JsonProperty("friend_Fullname")]
        public string friend_Fullname { get; set; }

        [JsonProperty("lastLogin")]
        public int friend_lastLogin { get; set; }

        [JsonProperty("friend_Conversation_ID")]
        public int friend_Conversation_ID { get; set; }

    }
}
