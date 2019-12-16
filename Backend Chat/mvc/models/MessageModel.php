<?php

class MessageModel extends DB{

    

    public function Get_Conversation_ID($pUser_ID=""){
        $qr = "SELECT conversation_id, user_id_1, user_id_2 FROM conversation_users 
        WHERE user_id_1 = $pUser_ID or user_id_2 = $pUser_ID ";
        return mysqli_query($this->con, $qr);
    }
    
    public function Get_Conversation_ID_2($pUser_ID="", $vFriend=""){
        
        
        $qr = "SELECT * FROM conversation
        WHERE ( user_id_1 = $pUser_ID AND user_id_2 = $vFriend ) or ( user_id_2 = $pUser_ID AND user_id_1 = $vFriend )";
        return mysqli_query($this->con, $qr);
    }

    public function Get_Conversation_Message($pConversation_ID="",$pIndex="",$pPage=0){
        // Chỉ get những message_id > index
        if($pIndex != "0" || $pIndex != ""){
            $pIndex = "AND message_id > ". $pIndex*1;
        }else{ $pIndex = ""; }

        // Define From To
        $pFrom = $pPage*10;
        $pTo = $pPage*10+9;

        
        $qr = "SELECT * FROM conversation_message WHERE conversation_id = $pConversation_ID ". $pIndex ." 
        ORDER BY message_id DESC LIMIT $pFrom,$pTo ";
        return mysqli_query($this->con, $qr);
    }



    public function UpdateLastSeen($pConID, $pUserID, $pValue = "0"){
    
        $qr = "SELECT * from conversation WHERE conversation_id = $pConID";
        $kData = mysqli_fetch_array(mysqli_query($this->con, $qr));
        if($kData["user_id_1"] == $pUserID) $pColumn = "seen1";
        else if($kData["user_id_2"] == $pUserID) $pColumn = "seen2";
        
        $qr = "UPDATE conversation set ".$pColumn."= '$pValue' where conversation_id = $pConID ";
        return mysqli_query($this->con, $qr);
    }


    public function Add_Conversation_Message($pConversation_ID = "", $pUser_ID = "", 
    $pMessage_Type = "", $pMessage_TypeName = "", $pMessage_Detail = ""){

        $currentDate = getStringTime(); 
        $qr = "INSERT INTO conversation_message (conversation_id,user_id,".$pMessage_TypeName.",message_type,time) 
        VALUES ('$pConversation_ID','$pUser_ID', '$pMessage_Detail','$pMessage_Type','$currentDate') ";
        
        echo $qr;
        return mysqli_query($this->con, $qr);
    }
    
    public function Add_MessageSeen($pConversation_ID, $pUser_ID){

        $qr = "SELECT * FROM conversation
        WHERE conversation_id = $pConversation_ID";
        $result_1 = mysqli_query($this->con, $qr);
        while($s = mysqli_fetch_array($result_1)){
            $user_id_one = $s["user_id_1"];
            $seen1 = $s["seen1"];
            $seen2 = $s["seen2"];
        }
        if($user_id_one == $pUser_ID){
            $qr = "UPDATE conversation SET seen2 = ($seen2*1 + 1) WHERE conversation_id = $pConversation_ID";
            
        }else{
            $qr = "UPDATE conversation SET seen1 = ($seen1*1 + 1) WHERE conversation_id = $pConversation_ID";
        }
        
        echo $qr;
        return mysqli_query($this->con, $qr);
    }
    
    public function ReadMessage($pConversation_ID, $pUser_ID){

        $qr = "SELECT user_id_1 FROM conversation
        WHERE conversation_id = $pConversation_ID";
        $result_1 = mysqli_query($this->con, $qr);
        while($s = mysqli_fetch_array($result_1)){
            $user_id_one = $s["user_id_1"];
        }
        if($user_id_one == $pUser_ID){
            $qr = "UPDATE conversation SET seen1 = 0 WHERE conversation_id = $pConversation_ID";
            
        }else{
            $qr = "UPDATE conversation SET seen2 = 0 WHERE conversation_id = $pConversation_ID";
        }
        
        echo $qr;
        return mysqli_query($this->con, $qr);
    }
    
    
    public function ChangeColor($pConversation_ID,$pUserID,$pColorID){
        
        $qr = "SELECT user_id_1 FROM conversation
        WHERE conversation_id = $pConversation_ID";
        $result_1 = mysqli_query($this->con, $qr);
        while($s = mysqli_fetch_array($result_1)){
            $user_id_one = $s["user_id_1"];
        }
        if($user_id_one == $pUserID){
            $qr = "UPDATE conversation SET color1 = $pColorID WHERE conversation_id = $pConversation_ID";
            
        }else{
            $qr = "UPDATE conversation SET color2 = $pColorID WHERE conversation_id = $pConversation_ID";
        }
        echo $qr;
        return mysqli_query($this->con, $qr);
    }


    public function Create_Conversation($pUser_ID, $pFriend){
        $qr = "SELECT conversation_id FROM conversation WHERE (user_id_1 = $pUser_ID AND user_id_2 = $pFriend) OR (user_id_2 = $pUser_ID AND user_id_1 = $pFriend)";
        
        $isExist = mysqli_query($this->con, $qr);
        if(mysqli_num_rows($isExist) == 0){
            $qr = "INSERT INTO conversation (user_id_1,user_id_2) 
            VALUES ('$pUser_ID','$pFriend') ";
            
            return mysqli_query($this->con, $qr);
        }else{

        }
        
        
        return mysqli_query($this->con, $qr);
    }


    

    
}

?>