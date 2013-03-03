<?php

/**
 * @author Christian Nieves
 * @copyright 2012
 */
 
 //make sure user isnt outdated
if(!$_GET["version"] || $_GET["version"] < 0008)
{
	exit("You must update Game Cloud. Visit http://www.gamecloud.xantecgames.com/Game Cloud.exe");
}


 $con = mysql_connect("localhost","USERNAME","PASSWORD") or die(mysql_error());
 mysql_select_db("DATABASE") or die(mysql_error());
 
$username = mysql_real_escape_string(urldecode($_GET["username"]));
$password = $_GET["password"];
$query = "SELECT username FROM users WHERE username='$username' && password='$password'";
$result = mysql_num_rows(mysql_query($query));

if ($result == 0)
{
	die('Incorrect username/password combination. Please try again.');
}
else if ($result == 1)
{
    echo md5($username . "ju8y6eRqge9VQwdW" . $password);
	$ip = $_SERVER['REMOTE_ADDR'];
	$version = $_GET["version"];
	$sql = "INSERT INTO logs (username, ipaddress, versionNumber) VALUES ('$username', '$ip', '$version');"; 
    $query = mysql_query($sql);
}
mysql_close($con);
 
 ?>