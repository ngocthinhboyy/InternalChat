<?php

class CaroModel extends DB{

    public function Get_Data($pGameID){
        $qr = "SELECT * FROM games_caro WHERE id = $pGameID";
        return mysqli_query($this->con, $qr);
    }
    
    
    public function CreateGame($user_1,$user_2,$whoseTurn){
        $idKun = time()+25200;
        $idKun = $idKun."a".$user_1."b".$user_2;
        
        $sql_1 = "INSERT INTO games_caro (id, id_kun, data, user_1, user_2, index_kun, whoseTurn, status) VALUES (NULL, '$idKun', '', '$user_1', '$user_2', '0', '$whoseTurn', '1')";
    
        $result_1 = mysqli_query($this->con, $sql_1);
        
        
        $sql_2 = "SELECT id FROM games_caro WHERE user_1 = $user_1 AND user_2 = $user_2 ORDER BY id DESC LIMIT 0,1 ";
         $result_2 = mysqli_query($this->con, $sql_2);
        while($row = mysqli_fetch_array($result_2)){
            
        $id = $row["id"];   
            
        }
            
        $arr = array('id' => $id);
        echo json_encode($arr,JSON_UNESCAPED_UNICODE);
        return $id;
    }
    
    

    
    public function Add_Data($game_id,$user_id,$index,$data){
        
        //status 
        //  0: Recently open
        //  1: Playing
        //  11: End - 1 win
        //  12: End - 2 win
        
        $data_kun = "";
        $isSuccess = "0";
        
       $sql_1 = "SELECT id,user_1,user_2,data,index_kun,whoseTurn FROM games_caro WHERE id = $game_id";
    
        $result_1 = mysqli_query($this->con, $sql_1);
    
        if (mysqli_num_rows($result_1) > 0) {
        
        // output data of each row
        while($row = mysqli_fetch_array($result_1)){
        $index_kun = $row["index_kun"];
        $user_1 = $row["user_1"];
        $user_2 = $row["user_2"];
        $whoseTurn = $row["whoseTurn"];
        $data_kun = $row["data"];
        }
    
    
    
        if($index_kun == $index && $user_id == $whoseTurn){
            if($data_kun != ""){
                $data_kun = $data_kun.",";
            }
            
            $data_kun = $data_kun.$data;
            $turn_kun = $user_1*1 + $user_2*1 - $user_id*1;
            $index = $index*1 + 1;
            $sql_2 = "update games_caro set data = '$data_kun', whoseTurn = '$turn_kun', index_kun = $index where id='$game_id'";
            $result_2 = mysqli_query($this->con, $sql_2);
            
            $isSuccess = "1";
        }

        }
        
        else{
            $isSuccess = "0";
        }


        $arr = array('status' => $isSuccess);
        echo json_encode($arr,JSON_UNESCAPED_UNICODE);
    }


}

?>