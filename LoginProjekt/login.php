<?php
$servername = "localhost:8070";
$username = "root";
$password = "";
$dbname = "customdb";

if(isset($argv[1])) $name = $argv[1];
if(isset($argv[2])) $pass = $argv[2];
if(!$name&&!$pass) {
	echo 'Missing or invalid input';		
	return;
}

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT * FROM userdb WHERE user LIKE '%s' AND password LIKE '%2s'";
$sql = sprintf($sql, $name, $pass);

$result = $conn->query($sql);

if ($result->num_rows > 0) {
	while($row = $result->fetch_assoc()) {
		echo "
		<!DOCTYPE html>
		<html>
			<head></head>
			<body>welcome user</body>
		</html>
		";
	}
} else {
	echo '{"status":"nope"}';
}
$conn->close();
?>