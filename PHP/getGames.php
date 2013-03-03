<?php

 $con = mysql_connect("localhost","USERNAME","PASSWORD") or die(mysql_error());
 mysql_select_db("DATABASE") or die(mysql_error());

$username = strtoupper(urldecode($_GET['username']));
 
$result = mysql_query("SELECT * FROM saves WHERE owner='$username' ORDER BY gameName");

$num = mysql_num_rows($result);

$games = array();

while($row = mysql_fetch_assoc($result))
{
	$games[] = $row["id"] . "," . $row["gameName"] . "," . $row["date"] . "," . $row["location"] . "," . $row["size"];
}

for($i=0; $i < count($games);$i++)
{
	if($i < count($games) -1)
	{
		echo $games[$i] . "\n";
	}
	else
	{
		echo $games[$i];
	}
}

?>