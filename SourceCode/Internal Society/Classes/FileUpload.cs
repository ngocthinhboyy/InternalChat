using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using xNet;
using System.Linq;


namespace Internal_Society
{
    public class FileUpload
    {
        private string urlUpload;
        private string pConversationID;
        private string pType;
        public string FilePath;
        public FileUpload(string urlUpload, string id, string type)
        {
            this.urlUpload = urlUpload;
            this.pConversationID = id;
            this.pType = type;
        }

        public bool UploadFile(string type)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            switch (type)
            {
                case "image":
                    dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                    break;
                case "otherFile":
                    dialog.Filter = "Image files (*.txt) |  *.txt";
                    break;
            }


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Task t = new Task(() => { UploadFileInChat(dialog.FileName); });
                t.Start();
                this.FilePath = dialog.FileName;
                return true;
            }
            return false;
        }


        private void AddCookie(HttpRequest http, string cookie)
        {
            var temp = cookie.Split(';');
            foreach (var item in temp)
            {
                var temp2 = item.Split('=');
                if (temp2.Count() > 1)
                {
                    http.Cookies.Add(temp2[0], temp2[1]);
                }
            }
        }


        private string UploadData(HttpRequest http, string url, MultipartContent data = null, string contentType = null, string userArgent = "", string cookie = null)
        {
            if (http == null)
            {
                http = new HttpRequest();
                http.Cookies = new CookieDictionary();
            }

            if (!string.IsNullOrEmpty(cookie))
            {
                AddCookie(http, cookie);
            }

            if (!string.IsNullOrEmpty(userArgent))
            {
                http.UserAgent = userArgent;
            }

            string html = http.Post(url, data).ToString();
            return html;
        }



        private void UploadFileInChat(string path)
        {
            MultipartContent data = new MultipartContent() {

                { new FileContent(path), "HinhAvatar", Path.GetFileName(path)}
            };

            var html = UploadData(null, this.urlUpload + this.pConversationID +
                "/" + this.pType + "/" + User_Info.k_ID, data);


        }
    }
}
