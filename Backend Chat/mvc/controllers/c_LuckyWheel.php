<?php


class c_LuckyWheel extends controller{

    function Show_Default(){
        require_once "./mvc/views/error_404.php";
    }

    function Play($pUser_ID=""){
        $lkwModel = $this->model("LuckyWheelModel");

        $result = new stdClass();
        $result = $lkwModel->Play($pUser_ID);
            
    }

    function BuyKey($pUser_ID="", $pQuantity = ""){
        
        $lkwModel = $this->model("LuckyWheelModel");
        if($lkwModel->BuyKey($pUser_ID, $pQuantity)){
            echo json_encode(new cSuccess("Buy successfully"));
        }else{
            echo json_encode(new cError("Buy failed"));
        }

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



class cSticker{
    public $ID;
    public $Name;
    public $Extension;
    public $Quantity;
    public $Price;
    public $Description;
    public $IsOwned;

    
    public function __construct($ID,$Name,$Extension,$Quantity,$Price,$Description,$IsOwned){
        $this->ID = $ID;
        $this->Name = $Name;
        $this->Extension = $Extension;
        $this->Quantity = $Quantity;
        $this->Price = $Price;
        $this->Description = $Description;
        $this->IsOwned = $IsOwned;

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