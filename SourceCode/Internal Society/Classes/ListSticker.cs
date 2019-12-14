using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Internal_Society
{
    class ListSticker
    {

        public static List<kSticker> data = new List<kSticker>();
        public static int Sequence = 0;
        private static string stringData = ""; 
        public async static void getSticker()
        {

            var urlPushData = App_Status.urlAPI + "c_Sticker/Get_Sticker_Store/" + User_Info.k_ID;
            try
            {
                Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlPushData); });
                // await
                string result = await getStringTask;

                if(result != "" && result != stringData)
                {
                    stringData = result;
                    Sequence++;
                    data.Clear();
                    kListSticker kLS = new JavaScriptSerializer().Deserialize<kListSticker>(result);
                    foreach (kSticker item in kLS.data)
                    {
                        data.Add(item);
                    }
                }
                

            }
            catch
            {
                
            }

        }

    }


    class kListSticker
    {

        public List<kSticker> data { get; set; }
        public bool success { get; set; }


    }

        public class kSticker
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public bool IsOwned { get; set; }
    }
}
