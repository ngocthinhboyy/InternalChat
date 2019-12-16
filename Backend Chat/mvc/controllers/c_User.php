<?php




class c_User extends controller{

    function Show_Default(){
        require_once "./mvc/views/error_404.php";
    }

    function Login($pUsername = "", $pPassword = ""){
        $usModel = $this->model("UserModel");
        $pPassword = md5($pPassword.$pUsername) . crypt($pPassword.$pUsername, '$6$');
        $us = $usModel->Login($pUsername,$pPassword);
        
        if(mysqli_num_rows($us) == 0){
            echo json_encode(new cError("Incorrect information"));
        }else{
            while($s = mysqli_fetch_array($us)){
            $usModel->UpdateLastLogin($s["user_id"]);
            echo json_encode(new cUser($s["user_id"], $s["username"], $s["fullname"], $s["diamond"], 
                $s["gold"], $s["luckyKey"], $s["gender"], $s["phone"], $s["email"], $s["birthday"], $s["status"], $s["address"], $s["urlAvatar"], $s["darkMode"], $s["searchAvailable"], $s["seeProfileAvailable"], $s["lastNotification"], "1" ));
            }
        }
        
    }
    
    function GetUserInfo($pUserID){
        $usModel = $this->model("UserModel");
        $us = $usModel->GetUserInfo($pUserID);
        
        if(mysqli_num_rows($us) == 0){
            echo json_encode(new cError("Incorrect id"));
        }else{
            while($s = mysqli_fetch_array($us)){
            $usModel->UpdateLastLogin($s["user_id"]);
            echo json_encode(new cUser($s["user_id"], $s["username"], $s["fullname"], $s["diamond"], 
                $s["gold"], $s["luckyKey"], $s["gender"], $s["phone"], $s["email"], $s["birthday"], $s["status"], $s["address"], $s["urlAvatar"], $s["darkMode"], $s["searchAvailable"], $s["seeProfileAvailable"], $s["lastNotification"], "1" ));
            }
        }
        
    }

    function Reg($pUsername="",$pPassword="",$pFullname="",$pQues_1="",
    $pAns_1="",$pQues_2="",$pAns_2=""){

        $usModel = $this->model("UserModel");
        $rands = generateRandomString(7);
        $pPassword = md5($pPassword.$pUsername) . crypt($pPassword.$pUsername, '$6$');
        $us = $usModel->Reg($pUsername,$pPassword,$pFullname,$pQues_1,
        $pAns_1,$pQues_2,$pAns_2,$rands);

        if($us) echo json_encode(new cSuccess("Reg successfully"));
        else echo json_encode(new cError("Reg failed"));

    }
    
    function Edit($pID = "", $pColumn = "", $pValue = "null"){
        $usModel = $this->model("UserModel");
        $us = $usModel->Edit($pID, $pColumn, $pValue);
        
        if($us) echo json_encode(new cSuccess("Update successfully"));
        else echo json_encode(new cError("Update failed"));
        

    }


    function EditAll($pID = "", $pFullname = "", $pBirthday = "", $pGender = "", 
    $pPhone = "", $pEmail = "", $pAddress = "", $pStatus = "", $pDarkMode = 0, $pSearchAvai = 1, $pSeeProfileAvai = 1 ){
        $usModel = $this->model("UserModel");
        $us = $usModel->EditAll($pID, $pFullname, $pBirthday, $pGender, 
        $pPhone, $pEmail,$pAddress,$pStatus,$pDarkMode,$pSearchAvai,$pSeeProfileAvai);
        if($us) echo json_encode(new cSuccess("Update successfully"));
        else echo json_encode(new cError("Update failed"));
        

    }


    function Search($pUserID ,$pData = "", $pPage = 0){
        $mang = [];
        $dataResult = new stdClass();
        $dataResult->success = true;
        
        $usModel = $this->model("UserModel");
        $us = $usModel->Search($pData, $pPage);
        
        
        
        while($s = mysqli_fetch_array($us)){
            $object = new stdClass();
            $object->user_id = $s["user_id"];
            $object->username = $s["username"];
            $object->fullname = $s["fullname"];
            $object->isFriend = false;
            
            
            if($usModel->SearchIsFriend($pUserID, $s["user_id"]) > 0) $object->isFriend = true;
            if($s["searchAvailable"] == true)
            array_push($mang, $object);
        }
        if(count($mang) == 0){
            array_push($mang, new cError("Incorect input"));
            $dataResult->success = false;
        };
        
        $dataResult->data = $mang;
        echo json_encode($dataResult);

    }


    function CheckExist($pUsername = ""){
        
        $usModel = $this->model("UserModel");
        $us = $usModel->CheckExist($pUsername);
        
        
        if($us == 1) echo json_encode(new cSuccess("You can use this username"));
        else if($us == 0) echo json_encode(new cError("Username is taken"));
        else if($us == -1) echo json_encode(new cError("Failed request"));
        

    }

    


}



class cUser{
    public $ID;
    public $Username;
    public $Fullname;
    public $Diamond;
    public $Gold;
    public $LuckyKey;
    public $Gender;
    public $Phone;
    public $Email;
    public $Birthday;
    public $Status;
    public $Address;
    public $urlAvatar;
    public $DarkMode;
    public $SearchAvailable;
    public $SeeProfileAvailable;
    
    public $lastNotification;
    public $Success;

    
    public function __construct($ID,$Username,$Fullname,$Diamond,$Gold,$LuckyKey,$Gender,$Phone,$Email,$Birthday,$Status,$Address,$urlAvatar,$DarkMode,$SearchAvailable,$SeeProfileAvailable,$lastNotification,$Success){
        $this->ID = $ID;
        $this->Username = $Username;
        $this->Fullname = $Fullname;
        $this->Diamond = $Diamond;
        $this->Gold = $Gold;
        $this->LuckyKey = $LuckyKey;
        $this->Gender = $Gender;
        $this->Phone = $Phone;
        $this->Email = $Email;
        $this->Birthday = $Birthday;
        $this->Status = $Status;
        $this->Address = $Address;
        $this->urlAvatar = $urlAvatar;
        $this->DarkMode = $DarkMode;
        $this->SearchAvailable = $SearchAvailable;
        $this->SeeProfileAvailable = $SeeProfileAvailable;
        $this->lastNotification = $lastNotification;
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