<?php

class UserModel extends DB{

    

    public function Login($pUsername,$pPassword){
        $qr = "SELECT * FROM user_info 
        WHERE username = '$pUsername' AND password = '$pPassword' ";
        return mysqli_query($this->con, $qr);
    }

    public function Reg($pUsername="",$pPassword="",$pFullname="",$pQues_1="",
    $pAns_1="",$pQues_2="",$pAns_2="",$rands=""){

        $existedAccount = $this->Login($pUsername,$pPassword);
        if ($existedAccount->num_rows > 0) return FALSE;
        $qr = "INSERT INTO user_info (username, password,fullname,ques_1,ans_1,ques_2,ans_2,keyFB, diamond, gold, luckyKey) 
        VALUES ('$pUsername', '$pPassword', '$pFullname', '$pQues_1', '$pAns_1', '$pQues_2', '$pAns_2','$rands', 25, 3000, 5) ";
        
        
        return mysqli_query($this->con, $qr);
    }
    
    
    public function GetUserInfo($pUserID){
        $qr = "SELECT * FROM user_info 
        WHERE user_id = $pUserID ";
        return mysqli_query($this->con, $qr);
    }
    

    public function Edit($pID = "", $pColumn = "", $pValue = "null"){
    
        $qr = "UPDATE user_info set ".$pColumn."= '$pValue' where user_id=$pID ";
        return mysqli_query($this->con, $qr);
    }

    public function EditAll($pID, $pFullname, $pBirthday, $pGender, 
    $pPhone, $pEmail,$pAddress, $pStatus, $pDarkMode, $pSearchAvai, $pSeeProfileAvai){
    
        $qr = "UPDATE user_info set fullname = '$pFullname', birthday = '$pBirthday',
        gender = '$pGender', phone = '$pPhone', email = '$pEmail', status = '$pStatus',
        address = '$pAddress', darkMode = $pDarkMode, searchAvailable =  $pSearchAvai, seeProfileAvailable = $pSeeProfileAvai 
        where user_id=$pID ";
        return mysqli_query($this->con, $qr);
    }

    public function Search($pData, $pPage){
        $pData = "%".$pData."%";
        $vFrom = $pPages*10;
        $vTo = $pPages*10+9;

        $qr = "SELECT user_id, username, fullname, searchAvailable FROM user_info WHERE username LIKE '$pData' OR fullname LIKE '$pData' LIMIT $vFrom,$vTo";
        return mysqli_query($this->con, $qr);
    }

    public function SearchIsFriend($pID_1, $pID_2){

        $qr = "SELECT id FROM friends WHERE (user_one_id = $pID_1 AND user_two_id = $pID_2) OR (user_two_id = $pID_1 AND user_one_id = $pID_2)  ";
        $result = mysqli_query($this->con, $qr);
        //echo $qr;
        return mysqli_num_rows($result);
        
    }
    
    
    public function CheckExist($pUsername = ""){

        $qr = "SELECT username FROM user_info WHERE username = '$pUsername'  ";
        $result = mysqli_query($this->con, $qr);
        if($result != TRUE) return -1;
        if(mysqli_num_rows($result) == 0) return 1;
        return 0;
    }


    public function UpdateLastLogin($pID = ""){
        $currentDate = getIntTime();
        $qr = "UPDATE user_info set lastLogin ='$currentDate' where user_id=$pID ";
        return mysqli_query($this->con, $qr);
    }

    

}

?>