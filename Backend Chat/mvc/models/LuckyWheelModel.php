<?php

class LuckyWheelModel extends DB{

    

    public function Play($pUser_ID){

        $kFrom = 1;
        $kTo = 8;

        $kGold = 0;
        $kDiamond = 0;
        $kLuckyKey = 0;

        $object = new stdClass();
        $object->success = false;
        $object->message = "Error";
        $object->index = -1;

        $qr = "SELECT luckyKey,diamond,gold FROM user_info
        WHERE user_id = $pUser_ID";
        $result_1 = mysqli_query($this->con, $qr);
        while($s = mysqli_fetch_array($result_1)){
            $userLuckyKey = $s["luckyKey"];
            $userDiamond = $s["diamond"];
            $userGold = $s["gold"];
        }
        
        if($userLuckyKey < 1){
            echo json_encode($object);
            return;
        }else{
            $qr = "UPDATE user_info SET luckyKey = ($userLuckyKey-1) 
            WHERE user_id = $pUser_ID";
            $result_update = mysqli_query($this->con, $qr);
            $userLuckyKey -= 1;
        }
        if($result_update == true){
            $object->success = true;

            $kIndex = rand($kFrom,$kTo);
            $object->index = $kIndex;

            switch ($kIndex) {
                case 1:
                    $kGold = rand(1000,5000);
                    $object->message = "You got $kGold gold , Congratulate !! ";
                    break;
                case 2:
                    $object->message = "Chuc ban may man lan sau";
                    echo json_encode($object);
                    return;
                case 3:
                    $kDiamond = rand(1,10);
                    $object->message = "You got $kDiamond diamond , Congratulate !! ";
                    break;
                case 4:
                    $kGold = rand(5000,20000);
                    $object->message = "You got $kGold gold , Congratulate !! ";
                    break;
                case 5:
                    $kLuckyKey = rand(1,5);
                    $object->message = "You got $kLuckyKey ticket , Congratulate !! ";
                    break;
                case 6:
                    $kGold = rand(3000,10000);
                    $object->message = "You got $kGold gold , Congratulate !! ";
                    break;
                case 7:
                    $object->message = "Chuc ban may man lan sau";
                    echo json_encode($object);
                    return;
                case 8:
                    $kDiamond = rand(5,20);
                    $object->message = "You got $kDiamond diamond , Congratulate !! ";
                    break;
                default:
                break;
            }
        }
        $qr = "UPDATE user_info SET luckyKey = ($userLuckyKey+$kLuckyKey),
        gold = ($userGold+$kGold), diamond = ($userDiamond+$kDiamond) 
            WHERE user_id = $pUser_ID";
        
        $result_update = mysqli_query($this->con, $qr);
        if($result_update == false){
            $object->success = false;
        }
        echo json_encode($object);
    }


    public function BuyKey($pUser_ID,$pQuantity){

        $priceDiamond = 5;

        
        $pQuantity = floor(abs($pQuantity));
        if($pQuantity < 1) return false;

        $qr = "SELECT diamond, luckyKey FROM user_info
        WHERE user_id = $pUser_ID";
        $result_1 = mysqli_query($this->con, $qr);
        while($s = mysqli_fetch_array($result_1)){
            $userDiamond = $s["diamond"];
            $userLuckyKey = $s["luckyKey"];
        }

        
        if($userDiamond >= $priceDiamond){
            
            
            $qr = "UPDATE user_info SET diamond = ($userDiamond-($priceDiamond*$pQuantity)),
            luckyKey = ($userLuckyKey + $pQuantity) 
            WHERE user_id = $pUser_ID";
            $result_update = mysqli_query($this->con, $qr);
            return true;
        }else{
            return false;
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

        $qr = "SELECT user_id, username, fullname, lastLogin FROM user_info WHERE user_id = $pUser_ID ";
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