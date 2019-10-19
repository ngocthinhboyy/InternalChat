<?php
$servername = "localhost";
$username = "anmnlcom_kun";
$password = "Soundofheart@1";
$dbname = "anmnlcom_it008";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}


?>