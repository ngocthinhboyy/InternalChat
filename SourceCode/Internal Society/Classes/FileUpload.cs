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
        private string id;
        public string FilePath; 
        public FileUpload(string urlUpload, string id)
        {
            this.urlUpload = urlUpload;
            this.id = id;
        }

        public bool UploadFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
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

            var html = UploadData(null, this.urlUpload + this.id +
                "/" + User_Info.k_ID, data);


        }
    }
}
