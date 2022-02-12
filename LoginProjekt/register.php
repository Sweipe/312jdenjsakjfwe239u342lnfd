<?php
$servername = "localhost:8070";
$username = "root";
$password = "";
$dbname = "customdb";

if(isset($argv[1])) $name = $argv[1];
if(isset($argv[2])) $pass = $argv[2];

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
$sql = "INSERT INTO `userdb` (`user`, `password`) VALUES ('%s', '%2s')";
$sql = sprintf($sql, $name, $pass);

$result = $conn->query($sql);

if ($result === TRUE) {
	echo "New record created successfully";
} 
else {
	echo "Error: " . $sql . "<br>" . $conn->error;
}
$conn->close();
?>