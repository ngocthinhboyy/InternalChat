<?php

class FriendModel extends DB{

    

    public function Get_FriendList($pUser_ID){
        
        $qr = "SELECT * FROM friends 
        WHERE status = true 
        AND ( user_one_id = '$pUser_ID' OR user_two_id = '$pUser_ID') ";
        return mysqli_query($this->con, $qr);
    }


    public function AddFriend($pUser_ID, $pFriend_ID){
        $qr = "SELECT * FROM friends 
        WHERE (user_one_id = '$pUser_ID' AND user_two_id = '$pFriend_ID') 
        OR (user_two_id = '$pUser_ID' AND user_one_id = '$pFriend_ID')";
        $requestExist = mysqli_query($this->con, $qr);
        $requestExist = mysqli_num_rows($requestExist);
        if($requestExist == 0){
            $qr = "INSERT INTO friends (user_one_id,user_two_id) 
            VALUES ($pUser_ID,$pFriend_ID) ";
            return mysqli_query($this->con, $qr);
        }
        
        return false;
        
    }

    public function AcceptFriend($pUser_ID, $pFriend_ID){
        
        $qr = "UPDATE friends SET status = 1 
        WHERE user_one_id = '$pFriend_ID' AND user_two_id = '$pUser_ID' ";
        return mysqli_query($this->con, $qr);
        
    }


    public function RemoveFriend($pUser_ID, $pFriend_ID){
        
        $qr = "DELETE FROM friends WHERE (user_one_id = '$pUser_ID' AND user_two_id = '$pFriend_ID') 
        OR (user_two_id = '$pUser_ID' AND user_one_id = '$pFriend_ID')";
        return mysqli_query($this->con, $qr);
        
    }

    public function CheckStatus($pUser_ID, $pFriend_ID){
        

        $qr = "SELECT user_one_id,user_two_id,status FROM friends WHERE
        (user_one_id = '$pUser_ID' AND user_two_id = '$pFriend_ID') 
        OR (user_two_id = '$pUser_ID' AND user_one_id = '$pFriend_ID') ";
        return mysqli_query($this->con, $qr);
    }

    public function GetFriendInfo($pUser_ID){

        $qr = "SELECT user_id, username, fullname, lastLogin, urlAvatar FROM user_info WHERE user_id = $pUser_ID ";
        return mysqli_query($this->con, $qr);
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