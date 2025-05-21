<?php 
try{
	$sunucu="localhost";
	$dbname="universite";
	$kadi="root";
	$ksifre="";
	$db=new PDO("mysql:host=".$sunucu.";dbname=".$dbname.";charset=utf8",$kadi,$ksifre);
	echo "Bağlantı " . $dbname . " Sağlandı.";
	
}catch(PDOException $e) {
	echo $e>getMessage();
}
?>
