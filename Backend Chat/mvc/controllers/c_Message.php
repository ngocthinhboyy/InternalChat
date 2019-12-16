<?php




class c_Message extends controller{

    function Show_Default(){
        require_once "./mvc/views/error_404.php";
    }

    function Get_Conversation_ID($pUser_ID=""){
        $usModel = $this->model("MessageModel");
        $us = $usModel->Get_Conversation_ID($pUser_ID);
        $mang = [];
        
        while($s = mysqli_fetch_array($us)){
            $vPartner = $s["user_id_1"];
            if($pUser_ID == $s["user_id_1"]) $vPartner = $s["user_id_2"];
            array_push($mang, new cConversation($s["conversation_id"], $vPartner));
        }
        if(count($mang) == 0){
            array_push($mang, new cError("No conversation"));
        };
        echo json_encode($mang);

    }

    function Get_Conversation_Message($pConversation_ID="",$pIndex="",$pPage=""){
        $mang = [];
        $object = new stdClass();
        $object->success = true;
        $usModel = $this->model("MessageModel");
        $us = $usModel->Get_Conversation_Message($pConversation_ID,$pIndex,$pPage);
        
        while($s = mysqli_fetch_array($us)){
            $vMessage_Detail = "";

            switch ($s["message_type"]) {
                case "text":
                    $vMessage_Detail = $s["message"];
                    break;
                case "sticker":
                    $vMessage_Detail = $s["sticker"];
                    break;
                case "image":
                    $vMessage_Detail = $s["image"];
                    break;
                case "otherFile":
                    $vMessage_Detail = $s["otherFile"];
                    break;
                default:
                    echo "Error";
            }
            array_push($mang, new cMessage($s["user_id"], $s["message_id"], $s["message_type"], $vMessage_Detail, 
                $s["time"]));
            
        }
        
        if(count($mang) == 0){
            array_push($mang, new cError("No message to get"));
            $object->success = false;
        };
        
        $object->data = $mang;
        
        echo json_encode($object);
    }
    
    
    
    function UpdateLastSeen($pConID = "", $pUserID = "", $pValue = "null"){
        $msModel = $this->model("MessageModel");
        $ms = $msModel->UpdateLastSeen($pConID, $pUserID, $pValue);
        
        if($ms) echo json_encode(new cSuccess("Update successfully"));
        else echo json_encode(new cError("Update failed"));
        

    }
    
    
    function Add_Conversation_Message($pConversation_ID = "", $pUser_ID = "", 
        $pMessage_Type = ""){
        $pMessage_Detail = $_POST["data"];
        $this->Add_MessageSeen($pConversation_ID,$pUser_ID);
        $this->ReadMessage($pConversation_ID,$pUser_ID);
        
        if(!isset($pMessage_Detail)) return;
        $mang = [];
        $msModel = $this->model("MessageModel");
        switch ($pMessage_Type) {
            case "text":
                $pMessage_TypeName = "message";
                break;
            case "sticker":
                $pMessage_TypeName = "sticker";
                break;
            case "image":
                $pMessage_TypeName = "image";
                break;
            case "otherFile":
                $pMessage_TypeName = "otherFile";
                break;
            default:
                array_push($mang, new cError("Invalid message type"));
                echo json_encode($mang);
                return;
        }
        $ms = $msModel->Add_Conversation_Message($pConversation_ID, $pUser_ID, $pMessage_Type, $pMessage_TypeName, $pMessage_Detail);
        
        
        if($ms) array_push($mang, new cSuccess("Add message successfully"));
        else array_push($mang, new cError("Add message failed"));
        echo json_encode($mang);

    }


    function Add_MessageSeen($pConversation_ID = "", $pUser_ID = ""){

        $msModel = $this->model("MessageModel");
        $msModel->Add_MessageSeen($pConversation_ID, $pUser_ID);
        
    }
    
    function ReadMessage($pConversation_ID = "", $pUser_ID = ""){

        $msModel = $this->model("MessageModel");
        $msModel->ReadMessage($pConversation_ID, $pUser_ID);
        
    }
    
    function ChangeColor($pConversation_ID = "", $pUserID = "", $pColorID = ""){

        $msModel = $this->model("MessageModel");
        $msModel->ChangeColor($pConversation_ID,$pUserID,$pColorID);
        
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