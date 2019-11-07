<?php

$k_username = $_GET["us"];
$k_password = $_GET["ps"];




include "connect.php";

$sql = "SELECT user_id,username,fullname,address,diamond,gold,gender,phone,birthday,email,status FROM user_info WHERE username = '$k_username' AND password = '$k_password' ";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    
    while($row = $result->fetch_assoc()) {
        
        
        $outp .= '{"ID":"'  . $row["user_id"] . '",';
        $outp .= '"Username":"'  . $row["username"] . '",';
        $outp .= '"Fullname":"'  . $row["fullname"] . '",';
        $outp .= '"Diamond":"'  . $row["diamond"] . '",';
        $outp .= '"Gold":"'  . $row["gold"] . '",';
        $outp .= '"Gender":"'  . $row["gender"] . '",';
        $outp .= '"Phone":"'  . $row["phone"] . '",';
        $outp .= '"Email":"'  . $row["email"] . '",';
        $outp .= '"Birthday":"'  . $row["birthday"] . '",';
        $outp .= '"Status":"'  . $row["status"] . '",';
        $outp .= '"Address":"'   . $row["address"] . '"}';
        
        //echo "username: " .$row[username]. "<br>";
    }
    

    echo $outp;
    
} else {
    /*echo "Sai username or password";*/
    echo -1;
}

/*$outp .="]";

echo $outp;

*/

$conn->close();

?>