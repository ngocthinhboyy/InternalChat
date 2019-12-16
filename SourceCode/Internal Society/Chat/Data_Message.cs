using System.Collections.Generic;

namespace Internal_Society
{



    public class Conversation_Message
    {
        public List<Data_Message> data { get; set; }
        public bool success { get; set; }
    }

    public class Data_Message
    {
        public string user_ID { get; set; }
        public string message_ID { get; set; }

        public string message_Type { get; set; }


        public string message_Detail { get; set; }



        public string message_Time { get; set; }



        public Data_Message() {

        }
        

    }

    public class Queue_Sticker
    {

        public static Queue<string> data;


    }


    


}
