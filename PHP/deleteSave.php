<?php

/**
 * @author Christian Nieves
 * @copyright 2012
 */
 
 $con = mysql_connect("localhost","USERNAME","PASSWORD") or die(mysql_error());
 mysql_select_db("DATABASE") or die(mysql_error());
 
$user1 = $_GET['username'];
$user = urldecode($user1);
$userUP = strtoupper($user);

$gameNames = mysql_real_escape_string(urldecode($_GET['gameNames']));
$games = explode(",", $gameNames);

$password = $_GET['password'];
$gHash = $_GET['gHash'];
$compareHash = strtoupper(md5($gameNames . "ju8y6eRqge9VQwdW"));

if($gHash == $compareHash)
{
	$query = "SELECT * FROM users WHERE username='$user' && password='$password'";
	$result = mysql_num_rows(mysql_query($query));
	if($result == 1)
	{
		foreach($games as $game)
		{
			unlink("upload/" . $userUP . "/" . $game . ".zip");
			mysql_query("DELETE FROM saves WHERE gameName='$game' AND owner='$userUP';");
		}

		echo "Done";
	}
	else if ($result == 0)
	{
		echo "Password";
	}
	mysql_close($con);
}
else
{
	echo "An unknown error occured";
}
?>