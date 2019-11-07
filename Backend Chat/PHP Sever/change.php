<?php

$k_id = $_GET["id"];
$k_type = $_GET["type"];
$k_value = $_GET["value"];




include "connect.php";

$sql = "update user_info set ".$k_type."='$k_value' where user_id=$k_id";
$result = $conn->query($sql);

echo $sql;

$conn->close();

?>