<?php 
require_once 'baglanti.php';
$ad=$_POST['name'];
$email=$_POST['email'];
$sifre=$_POST['sifre'];
$tel=$_POST['tel'];
$bolum=$_POST['bolum'];
$dogum_tarihi=$_POST['dogum_tarihi'];
$durum="aktif";
$kaydet=$db->prepare("INSERT into user set 
ad_soyad=:ad_soyad,
email=:email,
sifre=:sifre,
tel=:tel,
bolum=:bolum,
dogum_tarihi=:dogum_tarihi
");
$insert=$kaydet->execute(array(
'ad_soyad' => $ad,
'email' => $email,
'sifre' => $sifre,
'tel' => $tel,
'bolum' => $bolum,
'dogum_tarihi' => $dogum_tarihi
));
 
if($insert) {
	echo "Kayıt Başarılı";

}else{
	echo "Kayıt Başarısız";
}
?>