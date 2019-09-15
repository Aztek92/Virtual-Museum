<html>
<head>
<title>Muzeum VR - repozytorium</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="stylesheet" href="css/style.css" type="text/css" />
</head>

<body>

<div class = "toppanel">
<!-- LOGO -->
<div class="logo">
<span><a href = "index.php"><img src="images/logo.png" /></a></span>
</div>

<!-- MENU -->
<div class="menu">
        <div class="appdownload"><span><a href="museumvr.apk">Pobierz aplikacje</a></span></div>
        <div class="upload"><span><a href="upload.php">Wyślij eksponat</a></span></div>
</div>

</div> <!-- TOP PANEL-->



<!-- TABELA -->
<div class = test>

<div class = "content">
<div class = "stripes">
<span><img src="images/stripes.png"/></span>
</div>
<div class = "upload">




<table width="100%" class="tg">

<form action="adddebug.php" method="POST" ENCTYPE="multipart/form-data">

  <tr>
    <td class="tg-yw4l" rowspan="10" width="450px">Wytyczne dla wrzucanych eksponatów:<br/><br/>
	<ul>
		<li>1. Model powinien być w formacie .obj i nie przekraczać 10MB</li>
		<li>2. Obsługiwany format tekstur to .mat</li>
		<li>3. Obsługiwany format dołączonych opisów to .txt</li>
		<li>4. Należy dołączyć plik podglądu w formacie .jpg</li>
		<li>5. Model powinien być zeskanowany skanerem 3D</li>
		<li>6. Model nie może zawierać widocznych pustych wielokątów</li>
		<li>7. Model powinien być wycentrowany</li>
		<li>8. Eksponat musi zawierać wszystkie wymagane pliki</li>
		<li>9. Eksponat wymaga akceptacji administratora</li>
	</ul>
	</td>
    <td class="tg-yw4l">Nazwa:</td>
    <td class="tg-yw4l"><input type="text" name="name"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Opis:</td>
    <td class="tg-yw4l"><input type="text" name="description"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Autor:</td>
    <td class="tg-yw4l"><input type="text" name="author"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Rok:</td>
    <td class="tg-yw4l"><input type="text" name="year"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Muzeum:</td>
    <td class="tg-yw4l"><input type="text" name="museum"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Nazwa pliku:</td>
    <td class="tg-yw4l"><input type="text" name="filename"/><br/</td>
  </tr>
  <tr>
    <td class="tg-yw4l">Wybierz model:</td>
    <td class="tg-yw4l"><input type="file" name="objfile"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Wybierz teksturę:</td>
    <td class="tg-yw4l"><input type="file" name="matfile"/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Wybierz tekst:</td>
    <td class="tg-yw4l"><input type="file" name="txtfile"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l">Wybierz podglad:</td>
    <td class="tg-yw4l"><input type="file" name="jpgfile"/><br/></td>
  </tr>
  <tr>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l" colspan="2"><input type="submit" value="Wyślij eksopnat"/></td>
  </tr>
  </form>

</table>
<br/><br/><br/>
</div>

</div>
</div>


</div>




</body>
</html>