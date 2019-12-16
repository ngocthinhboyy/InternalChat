<?php

class c_Upload extends controller{
    
    /*
    function Show_Default($a=0, $b=0){
        $teo = $this->model("SinhVienModel");
        $tong = $teo->Tong($a,$b);
        $this->view("aoxau", [
            "Page" => "news",
            "Number" => $tong,
            "Mau" => "red",
            "SV" => $teo->SinhVien()
            ]); // ~ require ao dep .php
    }
    */

    function Show_Default($a=0, $b=0){
        echo $a;
        $x = $_FILES["HinhAvatar"];
        print_r($x);
        move_uploaded_file($x["tmp_name"],"./public/upload/".$x["name"]);
        $this->view("aoxau", [
            "Page" => "news",
            "Mau" => "red",
            ]); // ~ require ao dep .php
    }

    function upload_file($pConversation_ID,$pType,$pUser_ID){
        
        require_once "./mvc/core/kun_frame.php";
        $kPath = generateRandomString(21).getIntTime();
        
        if($pType == "avatar"){
            $usModel = $this->model("UserModel");
            $us = $usModel->Edit($pUser_ID, "urlAvatar", $kPath);
        }
        else if($pType == "otherFile"){
             $msModel = $this->model("MessageModel");
            $ms = $msModel->Add_Conversation_Message($pConversation_ID, $pUser_ID, "otherFile", $pMessage_TypeName = "otherFile", $kPath);
        
        }
        else{
            $msModel = $this->model("MessageModel");
            $ms = $msModel->Add_Conversation_Message($pConversation_ID, $pUser_ID, "image", $pMessage_TypeName = "image", $kPath);
        
        }
        
        $x = $_FILES["HinhAvatar"];
        print_r($x);
        move_uploaded_file($x["tmp_name"],"./public/upload/".$kPath);
        $this->view("aoxau", [
            "Page" => "news",
            "Mau" => "red",
            ]); // ~ require ao dep .php
    }
    
}

?>