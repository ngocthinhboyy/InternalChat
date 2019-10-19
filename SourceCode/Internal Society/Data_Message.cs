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
    }

    public class Data_Message
    {
        public string User_id { get; set; }
        public string Message { get; set; }

        public string Time { get; set; }

        public string Sticker { get; set; }

        public string Image { get; set; }

        public string Message_type { get; set; }

        public string Message_id { get; set; }

        public Data_Message() { }
        public Data_Message(string a, string b, string c, string d) {
            User_id = a;
            Message = b;
            Time = c;
            Message_id = d;
        }

    }

    public class Queue_Sticker
    {
        
        public static Queue<string> data;
        

    }


    

}
