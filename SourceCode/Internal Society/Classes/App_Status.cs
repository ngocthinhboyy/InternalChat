using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Society
{
    class App_Status
    {
        public static int HomePage_Width;
        public static int HomePage_Height;

        public static int HomePage_Top;
        public static int HomePage_Left;

        public static int time_delay = 1500;


        public static string urlAPI = "https://kunbr0.com/it008b/";
        public static string urlLocalResources = "../../Resources\\";
        public static string urlImage = "https://kunbr0.com/it008b/c_View/file/";
        public static string urlUpload = "https://kunbr0.com/it008b/c_Upload/upload_file/";


        public static int RedTabChat = 23;
        public static int GreenTabChat = 23;
        public static int BlueTabChat = 23;
        public static Color backFormColor = Color.FromArgb(42,42,49);
        public static Color backPanelColor;
        public static Color textColor;
        public static string iconDashboard;
        public static string iconProfile;
        public static string iconChat;
        public static string iconCart;
        public static string iconNoti;
        public static string iconGames;
    }
}
