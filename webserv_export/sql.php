<?php
$servername = "127.0.0.1:8081";
$username = "root";
$password = "";
$dbname = "collection";

//omringar värdena i $argv med '%'
//och kombinerar den till en text som bearbetas i SQL-anropen
if(count($argv) > 2) {
	$keystring = '';
	for($i = 1; $i < count($argv); $i++) {
		$keystring .= '%' . $argv[$i] . "%";
	}
} else if(count($argv) > 1) {
	$keystring = "%" . $argv[1] . "%";
}

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

if(!isset($keystring)) {
	$sql = "SELECT * FROM manga";
} else {
	$sql = "SELECT * FROM manga WHERE title LIKE '{$keystring}'";
}
$result = $conn->query($sql);

//antingen skrivs JSON av tabellens värden ut eller så skrivs inget
//som i script.js kommer betraktas som 'No result'
if ($result && $result->num_rows > 0) {
	$line = '';
	while($row = $result->fetch_assoc()) {
		if(strlen($line)>1) $line .= ',';
		$line .= '{"title":"%s","description":"%2$s","url":"%3$s","image":"%4$s"}';
		$line = sprintf($line, $row['title'], $row['description'], $row['url'], $row['image']);
	}
	echo '[' . $line . ']';
}
$conn->close();
?>