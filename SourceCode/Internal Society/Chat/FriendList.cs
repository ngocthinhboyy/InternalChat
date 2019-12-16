using System.Collections.Generic;

namespace Internal_Society
{
    public class FriendList
    {
        public List<Data_Friend> data { get; set; }
        public bool success { get; set; }
    }

    public class Data_Friend
    {
        public string friend_ID { get; set; }
        public string lastLogin { get; set; }

        public string friend_Username { get; set; }


        public string friend_Fullname { get; set; }

        public string friend_Conversation_ID { get; set; }
        public string lastSeen_ID { get; set; }


        public Data_Friend()
        {

        }


    }

}
