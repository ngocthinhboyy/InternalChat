<?php
include "connect.php";



$conversation_id = $_GET["c_id"];
$user_id = $_GET["u_id"];
$message = $_GET["u_message"];
$sticker = $_GET["u_sticker"];

$currentDate = date('Y-m-d h:i:s', time()+25200); 

$sql = "INSERT INTO conversation_message (conversation_id,user_id,message,sticker,time) VALUES ('$conversation_id','$user_id','$message','$sticker','$currentDate')";

$result = $conn->query($sql);



echo $currentDate;



$conn->close();

?>