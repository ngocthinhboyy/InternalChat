<?php




class c_Caro extends controller{

    function Show_Default(){
        require_once "./mvc/views/error_404.php";
    }

    function Get_Data($pGameID = ""){
        $crModel = $this->model("CaroModel");
        $cr = $crModel->Get_Data($pGameID);
        
        if(mysqli_num_rows($cr) == 0){
            echo json_encode(new cError("Error"));
        }else{
            while($s = mysqli_fetch_array($cr)){
            echo json_encode(new cGameData($s["id"], $s["data"], $s["user_1"], $s["user_2"], 
                $s["index_kun"], $s["whoseTurn"], $s["status"]));
            }
        }
        
    }


    function CreateGame($user_1 = "",$user_2 = "",$whoseTurn = ""){
        $crModel = $this->model("CaroModel");
        $cr = $crModel->CreateGame($user_1,$user_2,$whoseTurn);
        
        $noModel = $this->model("NotificationModel");
        $noModel->Add_Notification($user_1, $user_2, "CaroInvite", $cr);
       
        
    }
    
    

    function Add_Data($game_id = "",$user_id = "",$index = "",$data = ""){
        $crModel = $this->model("CaroModel");
        $cr = $crModel->Add_Data($game_id,$user_id,$index,$data);
        
       
        
    }
    
    
    


}



class cGameData{
    public $id;
    public $data;
    public $user_1;
    public $user_2;
    public $index;
    public $turn;
    public $game_status;
    public $success = 1;

    
    public function __construct($Id,$Data,$User_1,$User_2,$Index,$Turn,$Game_status){
        $this->id = $Id;
        $this->data = $Data;
        $this->user_1 = $User_1;
        $this->user_2 = $User_2;
        $this->index = $Index;
        $this->turn = $Turn;
        $this->game_status = $Game_status;

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