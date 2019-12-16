using System.Windows.Forms;

namespace Internal_Society
{
    public partial class Notification_AcceptFriend : UserControl
    {
        int FriendID;

        public Notification_AcceptFriend()
        {
            InitializeComponent();
        }

        public Notification_AcceptFriend(string fullname, int FriendID)
        {
            InitializeComponent();
            lb_Fullname.Text = fullname + " đã đồng ý kết bạn";
        }
    }
}
