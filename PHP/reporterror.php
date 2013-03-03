<?php

$clientName = urldecode($_GET['name']);
$clientDesc = urldecode($_GET['desc']);
$file = file_get_contents('php://input');
file_put_contents("errors/" . $clientName, $file);
 
mail("EMAIL", "Game Cloud Error Report", "Clients description is as follows : \n" . $clientDesc . "\n\nA new error has been reported, view it at : http://gamecloud.xantecgames.com/errors/" . $clientName);
echo "YAY";
 ?>