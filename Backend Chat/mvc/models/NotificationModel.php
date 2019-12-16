<?php

class NotificationModel extends DB{

    

    public function Get_Notification($pUser_ID, $pPage){

        // Define From To
        $pFrom = $pPage*10;
        $pTo = $pPage*10+9;

        $qr = "SELECT * FROM notification,user_info WHERE notification.sender = user_info.user_id AND receiver = '$pUser_ID' ORDER BY id DESC LIMIT $pFrom,$pTo ";
        return mysqli_query($this->con, $qr);
    }

    public function Add_Notification($pSender, $pReceiver, $pType, $pDetail){

        $qr = "INSERT INTO notification (sender, receiver, type, detail) 
        VALUES ('$pSender', '$pReceiver', '$pType', '$pDetail') ";
        
        return mysqli_query($this->con, $qr);
    }

    public function Delete_Notification($pSender, $pReceiver, $pType, $pDetail){

        $qr = "DELETE FROM notification WHERE sender = $pSender 
        AND receiver = $pReceiver AND type = '$pType' AND detail = $pDetail";
        
        return mysqli_query($this->con, $qr);
    }

}

?>