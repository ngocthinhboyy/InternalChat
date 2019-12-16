<?php
    class API_SinhVien extends controller{

        function DanhSach(){
            $sinhvien = $this->model("UserModel");
            $sv = $sinhvien->SinhVien();
            $mang = [];
            while($s = mysqli_fetch_array($sv)){
                array_push($mang, new SinhVien($s["id"], $s["hoten"], $s["namsinh"]));
            }

            echo json_encode($mang);
        }

    }


    class SinhVien{
        public $ID;
        public $HOTEN;
        public $NAMSINH;

        public function __construct($id, $hoten, $namsinh){
            $this->ID = $id;
            $this->HOTEN = $hoten;
            $this->NAMSINH = $namsinh;
        }
    }
?>