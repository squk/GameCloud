<?php
//used for monitoring amount of users online. 
 $con = mysql_connect("localhost","USERNAME","PASSWORD") or die(mysql_error());
 mysql_select_db("DATABASE") or die(mysql_error());
$status = $_GET["status"];
$username = urldecode($_GET["user"]);
//Increment counter
if($status == "ON")
{
	$query = "UPDATE users SET online=1 WHERE username='$username'";
	echo "ON";
}
else
{
	$query = "UPDATE users SET online=0 WHERE username='$username'";
	echo "OFF";
}
mysql_query($query);

?>