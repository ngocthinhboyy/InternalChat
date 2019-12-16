<?php




class c_Sticker extends controller{

    function Show_Default(){
        require_once "./mvc/views/error_404.php";
    }

    function Get_Sticker_Store($pUserID = ""){
        $dataResult = new stdClass();
        $dataResult->success = false;

        $skModel = $this->model("StickerModel");
        $sk = $skModel->Get_Sticker_Store($pUserID);
        $mang = [];
        
            while($s = mysqli_fetch_array($sk)){
                $kk = (mysqli_num_rows($skModel->IsOwned($pUserID,$s["id"])) >0)?true:false;
                array_push($mang, new cSticker($s["id"],
            $s["name"],$s["extension"],$s["quantity"], $s["price"], $s["description"],
            $kk ));
                $dataResult->success = true;
            }
        
        $dataResult->data = $mang;
        echo json_encode($dataResult);

    }

    function BuySticker($pUserID = "", $pStickerID = ""){
        $skModel = $this->model("StickerModel");
        if($skModel->BuySticker($pUserID, $pStickerID)){
            echo json_encode(new cSuccess("Buy successfully"));
        }else{
            echo json_encode(new cError("Buy failed"));
        }
    }


}



class cSticker{
    public $ID;
    public $Name;
    public $Extension;
    public $Quantity;
    public $Price;
    public $Description;
    public $IsOwned;

    
    public function __construct($ID,$Name,$Extension,$Quantity,$Price,$Description,$IsOwned){
        $this->ID = $ID;
        $this->Name = $Name;
        $this->Extension = $Extension;
        $this->Quantity = $Quantity;
        $this->Price = $Price;
        $this->Description = $Description;
        $this->IsOwned = $IsOwned;

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