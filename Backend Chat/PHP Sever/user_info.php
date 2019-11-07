<?php
include "connect.php";

$sql = "SELECT id,username FROM user_info";
$result = $conn->query($sql);
$outp = "[";

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


$conn->close();

?>