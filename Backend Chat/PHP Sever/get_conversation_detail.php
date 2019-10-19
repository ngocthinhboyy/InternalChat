<?php
include "connect.php";

$conversation_id = $_GET["c_id"];
$index = $_GET["index"];
$pages = 0;
$kFrom = $pages*10;
$kTo = $pages*10+9;


if($index != "0" || $index != ""){
    $index = "AND message_id > ". $index*1;
}else{ $index = ""; }


$sql = "SELECT time,image,sticker,message_type,message,user_id,message_id FROM conversation_message WHERE conversation_id = $conversation_id ". $index ." ORDER BY message_id DESC LIMIT $kFrom,$kTo ";

$result = $conn->query($sql);




if ($result->num_rows > 0) {
    $outp = '{"data":[';
    // output data of each row
    while($row = $result->fetch_assoc()) {
        if ($outp != '{"data":[') {$outp .= ",";}
        $outp .= '{"User_id":"'  . $row["user_id"] . '",';
        $outp .= '"Message_id":"'  . $row["message_id"] . '",';
        $outp .= '"Message_type":"'  . $row["message_type"] . '",';
        $outp .= '"Image":"'  . $row["image"] . '",';
        $outp .= '"Sticker":"'  . $row["sticker"] . '",';
        $outp .= '"Time":"'  . $row["time"] . '",';
        $outp .= '"Message":"'   . $row["message"] . '"}';
        
        //echo "username: " .$row[username]. "<br>";
    }
    $outp .="]}";
} else {
    echo "0";
}



echo $outp;



$conn->close();

?>