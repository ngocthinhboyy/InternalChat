﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Internal_Society
{

    public class ListSearchUser
    {
        public List<userSearchInfo> data { get; set; }
        public bool success { get; set; }
    }


    public class userSearchInfo
    {
        [JsonProperty("user_id")]
        public int user_id { get; set; }

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("fullname")]
        public string fullname { get; set; }

        [JsonProperty("isFriend")]
        public bool isFriend { get; set; }


    }
}
