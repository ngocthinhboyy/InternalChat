<?php
class app{

    protected $controller = "error_404";
    protected $action = "Show_Default";
    protected $params = [];

    function __construct(){
        // http://localhost:8888/Home/SayHi/1/2/3
        $arr = $this->UrlProcess();

        // Xu li Controller
        if(file_exists("./mvc/controllers/".$arr[0].".php")){
            $this->controller = $arr[0];
            unset($arr[0]);
        }
        require_once "./mvc/controllers/".$this->controller.".php";
        $this->controller = new $this->controller;

        // Xu li action

        if(isset($arr[1])){
            if(method_exists($this->controller,$arr[1])){
                $this->action = $arr[1];
                
            }
            unset($arr[1]);
        }

        // Xu li Params

        $this->params = $arr?array_values($arr):[];

       

        call_user_func_array([$this->controller,$this->action],$this->params);
       
    }

    function UrlProcess(){
        // Home/SayHi/1/2/3

        if(isset($_GET["url"])){
            return explode("/",filter_var(trim($_GET["url"],"/")));
            
        }
        
    }
}
?>