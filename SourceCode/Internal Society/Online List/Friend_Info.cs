using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Society
{   // dữ liệu của other users

    public class ListUserOnline
    {
        public List<Friend_Info> data { get; set; }
        public bool success { get; set; }
    }

    public class Friend_Info
    {
        public string friend_Avatar { get; set; }
        public string friend_ID { get; set; }
        public string friend_Username { get; set; }
        public string friend_Fullname { get; set; }
        public int friend_lastLogin { get; set; }
        public int friend_Conversation_ID { get; set; }

        public int ColorID { get; set; }

        public int NumOfUnSeenMessage { get; set; }

        public Friend_Info()
        {

        }
    }

    
}
