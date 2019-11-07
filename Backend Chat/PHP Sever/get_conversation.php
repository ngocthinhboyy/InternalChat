<?php
include "connect.php";

$kun_user_id = 1;

$sql = "SELECT conversation_id FROM conversation_users WHERE user_id_1 = $kun_user_id or user_id_2 = $kun_user_id";
$result = $conn->query($sql);


/*$outp = "[";

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        if ($outp != "[") {$outp .= ",";}
        $outp .= '{"Name":"'  . $row["username"] . '",';
        $outp .= '"ID":"'   . $row["id"] . '"}';
        
        //echo "username: " .$row[username]. "<br>";
    }
} else {
    echo "0 results";
}

$outp .="]";

echo $outp;

*/

$kkk = $result->fetch_assoc();
echo $kkk[conversation_id]. "<br/>";


$conn->close();

?>