<?php




class c_Notification extends controller{

    function Show_Default(){
        require_once "./mvc/views/error_404.php";
    }

    function Get_Notification($pUser_ID="", $pPage = 0){
        $mang = [];
        $dataResult = new stdClass();
        $dataResult->success = true;
        
        $noModel = $this->model("NotificationModel");
        $no = $noModel->Get_Notification($pUser_ID, $pPage);
        
        
        
        while($s = mysqli_fetch_array($no)){
            $object = new stdClass();
            $object->id = $s["id"];
            $object->sender = $s["sender"];
            $object->sender_fullname = $s["fullname"];
            $object->receiver = $s["receiver"];
            $object->type = $s["type"];
            $object->detail = $s["detail"];

            array_push($mang, $object);
        }
        if(count($mang) == 0){
            array_push($mang, new cError("No notification to get !"));
            $dataResult->success = false;
        };
        
        $dataResult->data = $mang;
        echo json_encode($dataResult);

    }

    
    
    function Add_Notification($pSender, $pReceiver, $pType, $pDetail){
        $mang = [];
        $noModel = $this->model("NotificationModel");
        
        return $noModel->Add_Notification($pSender, $pReceiver, $pType, $pDetail);

    }


    function Create_Conversation($pUser_ID = "", $pFriend){
        $mang = [];
        $usModel = $this->model("MessageModel");
        
        $us = $usModel->Create_Conversation($pUser_ID, $pFriend);
        
        

    }


    public function UpdateLastLogin($pID = ""){
        $currentDate = getIntTime();
        $qr = "UPDATE user_info set lastLogin ='$currentDate' where user_id=$pID ";
        return mysqli_query($this->con, $qr);
    }
    

}



class cMessage{
    public $user_ID;
    public $message_ID;
    public $message_Type; // 0-Text, 1-Sticker, 2-Image
    public $message_Detail;
    public $message_Time;
    

    
    public function __construct($user_ID,$message_ID,$message_Type,$message_Detail,$message_Time){
        $this->user_ID = $user_ID;
        $this->message_ID = $message_ID;
        $this->message_Type = $message_Type;
        $this->message_Detail = $message_Detail;
        $this->message_Time = $message_Time;

    }
}

class cConversation{
    public $conversation_ID;
    public $partner_ID;
    

    public function __construct($conversation_ID,$partner_ID){
        $this->conversation_ID = $conversation_ID;
        $this->partner_ID = $partner_ID;

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