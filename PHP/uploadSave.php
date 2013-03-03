<?php

/**
 * @author Christian Nieves
 * @copyright 2012
 */
 
 $con = mysql_connect("localhost","USERNAME","PASSWORD") or die(mysql_error());
 mysql_select_db("EMAIl") or die(mysql_error());
 
$user1 = $_GET['user'];
$fileHash = $_GET['hash'];
$location =  mysql_real_escape_string(urldecode($_GET['location']));
$gameName = mysql_real_escape_string(urldecode($_GET['gameName']));

$user = urldecode($user1);
$userUP = strtoupper($user);
$file = file_get_contents('php://input');
file_put_contents("upload/tmp_" . $userUP . "_" . $gameName . ".zip", $file);
$tmpZipHash = strtoupper(hash_file("md5", "upload/tmp_" . $userUP . "_" . $gameName . ".zip"));
$tmpFullHash = strtoupper(md5($tmpZipHash . "ju8y6eRqge9VQwdW"));
$filesize = format_bytes(filesize("upload/tmp_" . $userUP . "_" . $gameName . ".zip"));

if($fileHash == $tmpFullHash)
{
    if(!is_dir('upload/' . $userUP))
    {
        mkdir('upload/' . $userUP);
    }
	if(copy("upload/tmp_" . $userUP . "_" . $gameName . ".zip", "upload/" . $userUP . "/" . $gameName . ".zip"))
	{
		if(file_exists("upload/tmp_" . $userUP . "_" . $gameName . ".zip"))
		{
			unlink("upload/tmp_" . $userUP . "_" . $gameName . ".zip");
		}
	}
	
    $result = mysql_query("UPDATE saves SET date=NOW(), size='$filesize' WHERE gameName='$gameName' AND owner='$userUP';");
    
    if(mysql_affected_rows()==0)
    {
        $result2 = mysql_query("REPLACE INTO saves (gameName, owner, date, location, size) VALUES ('$gameName','$userUP', NOW(), '$location', '$filesize');");
    }
    echo "Done";
}
else
{
    echo "It appears as if the file attempting to be uploaded has been tampered with. ";
}

mysql_close($con);

function format_bytes($a_bytes)
{
    if ($a_bytes < 1024) {
        return $a_bytes .' B';
    } elseif ($a_bytes < 1048576) {
        return round($a_bytes / 1024, 2) .' KB';
    } elseif ($a_bytes < 1073741824) {
        return round($a_bytes / 1048576, 2) . ' MB';
    } elseif ($a_bytes < 1099511627776) {
        return round($a_bytes / 1073741824, 2) . ' GB';
    } elseif ($a_bytes < 1125899906842624) {
        return round($a_bytes / 1099511627776, 2) .' TiB';
    } elseif ($a_bytes < 1152921504606846976) {
        return round($a_bytes / 1125899906842624, 2) .' PiB';
    } elseif ($a_bytes < 1180591620717411303424) {
        return round($a_bytes / 1152921504606846976, 2) .' EiB';
    } elseif ($a_bytes < 1208925819614629174706176) {
        return round($a_bytes / 1180591620717411303424, 2) .' ZiB';
    } else {
        return round($a_bytes / 1208925819614629174706176, 2) .' YiB';
    }
}

?>