<?php

class StickerModel extends DB{

    public function Get_Sticker_Store($pUser_ID){
        $qr = "SELECT * FROM sticker_store";
        return mysqli_query($this->con, $qr);
    }
    
    public function IsOwned($pUser_ID, $pStickerID){
        
        $qr = "SELECT id FROM sticker_purchase
        WHERE user_id = $pUser_ID AND sticker_id = $pStickerID";
        return mysqli_query($this->con, $qr);
    }


    public function BuySticker($pUser_ID, $pStickerID){
        
        $qr = "SELECT id FROM sticker_purchase
        WHERE user_id = $pUser_ID AND sticker_id = $pStickerID";
        if(mysqli_num_rows(mysqli_query($this->con, $qr)) > 0) return false;


        $qr = "SELECT price FROM sticker_store
        WHERE id = $pStickerID";
        $result_1 = mysqli_query($this->con, $qr);
        while($s = mysqli_fetch_array($result_1)){
            $price = $s["price"];
        }

        $qr = "SELECT gold FROM user_info
        WHERE user_id = $pUser_ID";
        $result_2 = mysqli_query($this->con, $qr);
        while($s = mysqli_fetch_array($result_2)){
            $gold = $s["gold"];
        }

        
        if($gold > $price){
            
            
            $qr = "UPDATE user_info SET gold = ($gold-$price) 
            WHERE user_id = $pUser_ID";
            $result_updateGold = mysqli_query($this->con, $qr);
            $qr = "INSERT INTO sticker_purchase (user_id,sticker_id,price) VALUES 
            ($pUser_ID,$pStickerID,$price)";
            $result_insertBill = mysqli_query($this->con, $qr);
            return true;
        }else{
            return false;
        }

        return false;
    }





    
}

?>