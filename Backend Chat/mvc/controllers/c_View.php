<?php

class c_View extends controller{
    
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
        echo $a."---";
        $x = $_FILES["HinhAvatar"];
        print_r($x);
        move_uploaded_file($x["tmp_name"],"./public/upload/".$x["name"]);
        $this->view("aoxau", [
            "Page" => "news",
            "Mau" => "red",
            ]); // ~ require ao dep .php
    }

    function file($type,$url){
        if($type == "2"){
            header("Content-type: image/png");
        }else if(type=="3"){
            header("Content-Type: text/plain");
        }
        
        $path = "./public/upload/". $url;
        
        

        echo file_get_contents("$path");
        //include "$path";
    }
    
}

?>