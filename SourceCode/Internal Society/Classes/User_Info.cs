using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{
    public class User_Info
    {
        public static string k_Username;
        public static string k_ID;
        public static string k_Fullname;
        public static string k_Diamond;
        public static string k_Gold;
        public static string k_Gender;
        public static string k_Phone;
        public static string k_Email;
        public static string k_Birthday;
        public static string k_Status;
        public static string k_Address;
        public static string k_Avatar;

        private async static void ExecuteUpdate()
        {
            string urlSearchUser = App_Status.urlAPI + "c_User/EditAll/" + User_Info.k_ID + "/" + k_Fullname + "/" 
                + k_Birthday + "/" + k_Gender + "/" + k_Phone + "/" + k_Email + "/" + k_Address + "/" + k_Status;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            if (data.Success == "1")
            {
                MessageBox.Show("Update successfully !");
            }
            else
            {
                MessageBox.Show("Something wrong !!");
            }
        }

        public static void UpdateUserInfo()
        {
            ExecuteUpdate();
        }
    }

    
}
