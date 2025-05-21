<strong>Random Sayı Değerleri</strong>
<br>
<br>
<?php 
$Sayi1=rand(0,200);
$Sayi2=rand(0,10) ;
$topla=$Sayi1+$Sayi2;
$cikar=$Sayi1-$Sayi2;
$bol=$Sayi1/$Sayi2;
$carp=$Sayi1*$Sayi2;
?>
<strong>İlk Sayı Değeri:</strong> <?php echo $Sayi1 ?><br>
<strong>İkinci Sayı Değeri:</strong> <?php echo $Sayi2 ?><br>
<hr></hr>

<strong>Toplama İşlemi </strong><br>
<strong>Sonuç: <?php echo $Sayi1 . "+" . $Sayi2 ?>: </strong> <?php echo $topla ?> <br><hr></hr>
<strong>Çıkarma İşlemi </strong><br>
<strong>Sonuç: <?php echo $Sayi1 . "-" . $Sayi2 ?>: </strong> <?php echo $cikar ?> <br><hr></hr>
<strong>Bölme İşlemi </strong><br>
<strong>Sonuç: <?php echo $Sayi1 . "/" . $Sayi2 ?>: </strong> <?php echo $bol ?> <br><hr></hr>
<strong>Çarpma İşlemi </strong><br>
<strong>Sonuç: <?php echo $Sayi1 . "*" . $Sayi2 ?>: </strong> <?php echo $carp ?> <br><hr></hr>