<html>
<head>
<title> Veri Ekleme </title>
</head>
<body>
<form action="kayit_isle.php" method="POST">
<strong> Adınız Soyadınız: </strong>
<input type="text" name="name"/><br>
<strong> Email Adresiniz: </strong>
<input type="text" name="email"/><br>
<strong> Şifreniz: </strong>
<input type="password" name="sifre"/><br>
<strong> Telefon: </strong>
<input type="text" name="tel"/><br>
<strong>Bölüm:</strong>
<select name="bolum">
<option value="Bilgisayar Programcılığı"> Bilgisayar Programcılığı </option>
<option value="Çağrı Hizmetleri"> Çağrı Hizmetleri </option>
<option value="Sosyal Güvenlik"> Sosyal Güvenlik </option>
<option value="Dış Ticaret"> Dış Ticaret </option>
<option value="Sivil Savunma"> Sivil Savunma </option>
</select>
<br>
<strong> Dogum Tarihi: </strong>
<input type="number" min="1990" max="2025" name="dogum_tarihi"/><br>
<input type="submit" value="Kaydet" name="form_kayit"/>
</form>
</body>
</html>

