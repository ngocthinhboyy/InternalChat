<?php


class c_Friend extends controller{

    function Show_Default(){
        require_once "./mvc/views/error_404.php";
    }

    function Get_FriendList($pUser_ID=""){
        
        $usModel = $this->model("UserModel");
        $usModel->UpdateLastLogin($pUser_ID);
        $fModel = $this->model("FriendModel");
        $msModel = $this->model("MessageModel");
        $us = $fModel->Get_FriendList($pUser_ID);
        $mang = [];
        $object = new stdClass();
        $object->success = true;
        
        while($s = mysqli_fetch_array($us)){
            $vFriend = $s["user_one_id"];
            if($pUser_ID == $s["user_one_id"]) $vFriend = $s["user_two_id"];
            $dataFriend = mysqli_fetch_array($fModel->GetFriendInfo($vFriend));
            $friend_LastLogin = $dataFriend["lastLogin"];
            $friend_Username = $dataFriend["username"];
            $friend_Fullname = $dataFriend["fullname"];
            $friend_Avatar = $dataFriend["urlAvatar"];
            
            $ms = mysqli_fetch_array($msModel->Get_Conversation_ID_2($pUser_ID,$vFriend));
            $friend_Conversation_ID = $ms["conversation_id"];
            if($ms["user_id_1"] == $pUser_ID){
                $lastSeen_ID = $ms["seen1"];
                $ColorID = $ms["color1"];
            }else{
                $lastSeen_ID = $ms["seen2"];
                $ColorID = $ms["color2"];
            }
            
            
            array_push($mang, new cFriend($vFriend,$friend_LastLogin,$friend_Username,$friend_Fullname,$friend_Avatar,$friend_Conversation_ID, $lastSeen_ID,$ColorID));
        }
        if(count($mang) == 0){
            array_push($mang, new cError("No friend"));
            $object->success = false;
        };
        
        $object->data = $mang;
        echo json_encode($object);

    }

    function CheckStatus($pUser_ID = "", $pFriend_ID = ""){
        
        $usModel = $this->model("FriendModel");
        $us = $usModel->CheckStatus($pUser_ID,$pFriend_ID);
        $mang = [];
        
        while($s = mysqli_fetch_array($us)){
            if($s["status"]*1 == 1){
                // Already been friend together
                array_push($mang, new cStatus("1","1"));
            }
            else if($s["status"]*1 == 0){
                if($s["user_one_id"] == $pUser_ID){
                    // You are sending request and wait for acepting
                    array_push($mang, new cStatus("2","1"));
                }
                else if($s["user_one_id"] == $pFriend_ID){
                    // You received an adding friend request
                    array_push($mang, new cStatus("3","1"));
                }
            }
        }
        if(count($mang) == 0){
            array_push($mang, new cError("No thing"));
        };
        echo json_encode($mang);

    }

    function AddFriend($pUser_ID = "", $pFriend_ID = ""){
        $mang = [];
        $usModel = $this->model("FriendModel");
        $us = $usModel->AddFriend($pUser_ID, $pFriend_ID);
        
        if($us){
            
            $noModel = $this->model("NotificationModel");

            //FriendRequest->Detail = 0: sent friend request, 1: accepted friend request
            if($noModel->Add_Notification($pUser_ID, $pFriend_ID, "FriendRequest", 0)){
                array_push($mang, new cSuccess("Sent successfully"));
            }
        }
        else array_push($mang, new cError("Request failed"));
        echo json_encode($mang);

    }

    function AcceptFriend($pUser_ID = "", $pFriend_ID = ""){
        $ketqua;
        $msModel = $this->model("MessageModel");
        $ms = $msModel->Create_Conversation($pUser_ID, $pFriend_ID);
        
        $usModel = $this->model("FriendModel");
        $us = $usModel->AcceptFriend($pUser_ID, $pFriend_ID);
        

        if($us){
            $noModel = $this->model("NotificationModel");

            //FriendRequest->Detail = 0: sent friend request, 1: accepted friend request
            if($noModel->Delete_Notification($pFriend_ID, $pUser_ID, "FriendRequest", 0) && $noModel->Add_Notification($pUser_ID, $pFriend_ID, "FriendRequest", 1)){
                $ketqua = new cSuccess("Accepted successfully");
            }else{
                $ketqua = new cError("Accepted failed");
            }
        } 
        else $ketqua = new cError("Accepted failed");
        echo json_encode($ketqua);

    }

    function RemoveFriend($pUser_ID = "", $pFriend_ID = ""){
        $ketqua;
        $usModel = $this->model("FriendModel");
        $us = $usModel->RemoveFriend($pUser_ID, $pFriend_ID);
        
        if($us){
            $noModel = $this->model("NotificationModel");

            //FriendRequest->Detail = 0: sent friend request, 1: accepted friend request
            if($noModel->Delete_Notification($pUser_ID, $pFriend_ID, "FriendRequest", 0)){
                $ketqua = new cSuccess("Removed successfully");
            }else{
                $ketqua = new cError("Request failed");
            }
        } 
        else $ketqua = new cError("Request failed");
        echo json_encode($ketqua);

    }

    public function UpdateLastLogin($pID = ""){
        $currentDate = getIntTime();
        $qr = "UPDATE user_info set lastLogin ='$currentDate' where user_id=$pID ";
        return mysqli_query($this->con, $qr);
    }
    

}



class cFriend{
    public $friend_ID;
    public $friend_lastLogin;
    public $friend_Username;
    public $friend_Fullname;
    public $friend_Avatar;
    public $friend_Conversation_ID;
    public $NumOfUnSeenMessage;
    public $ColorID = 0;
    
    public function __construct($friend_ID, $friend_lastLogin, $friend_Username,$friend_Fullname,$friend_Avatar,$friend_Conversation_ID,$NumOfUnSeenMessage,$ColorID){
        $this->friend_ID = $friend_ID;
        $this->friend_lastLogin = $friend_lastLogin;
        $this->friend_Username = $friend_Username;
        $this->friend_Fullname = $friend_Fullname;
        $this->friend_Avatar = $friend_Avatar;
        $this->friend_Conversation_ID = $friend_Conversation_ID;
        $this->NumOfUnSeenMessage = $NumOfUnSeenMessage;
        $this->ColorID = $ColorID;
        
    }
}

class cStatus{
    public $status;
    public $Success;

    public function __construct($status,$Success){
        $this->status = $status;
        $this->Success = $Success;
    }
}


class cError{
    public $Success = "0";
    public $Message;

    public function __construct($Message = "Error"){
        $this->Message = $Message;
    }
}

class cSuccess{
    public $Success = "1";
    public $Message;

    public function __construct($Message = "Success"){
        $this->Message = $Message;
    }
}
?>