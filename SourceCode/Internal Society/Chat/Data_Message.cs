using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public Data_Message() { }
        public Data_Message(string user_ID, string message_ID, string message_Type,
            string message_Detail, string message_Time)
        {

            this.user_ID = user_ID;
            this.message_ID = message_ID;
            this.message_Type = message_Type;
            this.message_Detail = message_Detail;
            this.message_Time = message_Time;

        }

    }

    public class Queue_Sticker
    {

        public static Queue<string> data;


    }




}
