<?php

/**
 * @author Christian Nieves
 * @copyright 2012
 */
 
$username = urldecode($_GET["username"]);
$user2 = strtoupper($username);
$gameName = urldecode($_GET["gameName"]);

$file = "upload/$user2/$gameName.zip";
if(!isset($_GET['checker']) {  exit("Please update Game Cloud");

if($_GET['checker'] == md5($username + $gameName + "ju8y6eRqge9VQwdW")) {
	if (file_exists($file)) {
		header('Content-Description: File Transfer');
		header('Content-Type: application/octet-stream');
		header('Content-Disposition: attachment; filename='.basename($file));
		header('Content-Transfer-Encoding: binary');
		header('Expires: 0');
		header('Cache-Control: must-revalidate');
		header('Pragma: public');
		header('Content-Length: ' . filesize($file));
		ob_clean();
		flush();
		readfile($file);
	}
	else {
		echo "An unknown error has occured on the server";
	}
}
else {
	echo "An unknown error has occured on the server";
}

?>