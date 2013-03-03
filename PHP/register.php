<?php

/**
 * @author Christian Nieves
 * @copyright 2012
 */
 $con = mysql_connect("localhost","USERNAME","PASSWORD") or die(mysql_error());
 mysql_select_db("DATABASE") or die(mysql_error());

$pUsername = urldecode($_GET['username']);
$pPassword = md5(urldecode($_GET['password']) . "ju8y6eRqge9VQwdW");
$pEmail = urldecode($_GET['email']);
$error = "";
/*
else if ($result == 1)
{
    echo md5($username . "ctnieves97" . $password);
}
*/

if (!empty($pUsername) && !empty($pPassword) && !empty($pEmail))
{ 
    $uLen = strlen($pUsername); 
    $pLen = strlen($pPassword); 
     
    // escape the $pUsername to avoid SQL Injections 
    $eUsername = mysql_real_escape_string($pUsername); 
    $sql = "SELECT username FROM users WHERE username = '$eUsername' LIMIT 1"; 
    
    // Note the use of trigger_error instead of or die. 
    $query = mysql_query($sql) or trigger_error("Query Failed: " . mysql_error()); 
 
    // Error checks (Should be explained with the error) 
    if ($uLen <= 4 || $uLen >= 16)
    { 
      $error = "Username must be between 4 and 16 characters."; 
      echo $error;
    }
    else if ($pLen < 6)
    { 
      $error = "Password must be longer then 6 characters."; 
      echo $error;
    }
    else if(!validEmail($pEmail))
    { 
      $error = "The email address you entered is not valid";
      echo $error;
    }
    else if (mysql_num_rows($query) == 1)
    { 
      $error = "Username already exists."; 
      echo $error;
    }
    else
    { 
      // All errors passed lets 
      // Create our insert SQL by hashing the password and using the escaped Username. 
      $sql = "INSERT INTO users (username, password, email) VALUES ('$eUsername', '" . $pPassword . "', '$pEmail');"; 
       
      $query = mysql_query($sql) or trigger_error("Query Failed: " . mysql_error()); 
      if ($query)
      { 
        echo "Successfully registered.";
      }   
    } 
  } 

function validEmail($email)
{
   $isValid = true;
   $atIndex = strrpos($email, "@");
   if (is_bool($atIndex) && !$atIndex)
   {
      $isValid = false;
   }
   else
   {
      $domain = substr($email, $atIndex+1);
      $local = substr($email, 0, $atIndex);
      $localLen = strlen($local);
      $domainLen = strlen($domain);
      if ($localLen < 1 || $localLen > 64)
      {
         // local part length exceeded
         $isValid = false;
      }
      else if ($domainLen < 1 || $domainLen > 255)
      {
         // domain part length exceeded
         $isValid = false;
      }
      else if ($local[0] == '.' || $local[$localLen-1] == '.')
      {
         // local part starts or ends with '.'
         $isValid = false;
      }
      else if (preg_match('/\\.\\./', $local))
      {
         // local part has two consecutive dots
         $isValid = false;
      }
      else if (!preg_match('/^[A-Za-z0-9\\-\\.]+$/', $domain))
      {
         // character not valid in domain part
         $isValid = false;
      }
      else if (preg_match('/\\.\\./', $domain))
      {
         // domain part has two consecutive dots
         $isValid = false;
      }
      else if
(!preg_match('/^(\\\\.|[A-Za-z0-9!#%&`_=\\/$\'*+?^{}|~.-])+$/',
                 str_replace("\\\\","",$local)))
      {
         // character not valid in local part unless 
         // local part is quoted
         if (!preg_match('/^"(\\\\"|[^"])+"$/',
             str_replace("\\\\","",$local)))
         {
            $isValid = false;
         }
      }
      if ($isValid && !(checkdnsrr($domain,"MX") || checkdnsrr($domain,"A")))
      {
         // domain not found in DNS
         $isValid = false;
      }
   }
   return $isValid;
}

mysql_close($con);
 
 ?>