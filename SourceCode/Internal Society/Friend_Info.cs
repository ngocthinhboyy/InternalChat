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
        [JsonProperty("user_ID")]
        public string friend_ID { get; set; }

        [JsonProperty("user_Name")]
        public string friend_Username { get; set; }

        [JsonProperty("user_Fullname")]
        public string friend_Fullname { get; set; }

    }
}
