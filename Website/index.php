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
<div class = "lista">

<table width="100%" border="1px">
			<tr>
                <th>Podgląd</th>
				<th>Nazwa</th>
				<th>Opis</th>
				<th>Data dodania</th>
                <th>Autor</th>
                <th>Rok</th>
				<th>Muzeum</th>
				<th>Do pobrania</th>
			</tr>
            <?php
                $db_address = 'localhost';
                $db_name = 'muzeumvr';
                $db_login = 'root';
                $db_password = '';

				mysql_connect($db_address,$db_login,$db_password) or die(mysql_error());
				mysql_select_db($db_name) or die("Nie można połączyć z bazą danych");
                $result = mysql_query("SELECT `name`, `description`, `upload_date`, `author`, `year`, `museum`, `filename` FROM `Model` WHERE verified = 1");
                
				while($row = mysql_fetch_row($result))
				{
                    Print "<tr>";
                        Print "<td> <img src =\inz\models\\" . $row[6] . "\\" . $row[6] . ".jpg width=100px height=100px> </td>";
						Print '<td align="center">'. $row[0] . "</td>";
						if (strlen($row[1])>100) { 
							Print '<td align="center">'. substr($row[1],0,100) . "... (...) </td>"; 
						}
							else { 
								Print '<td align="center">'. $row[1] . "</td>";
							}
						Print '<td align="center">'. $row[2] . "</td>";
                        Print '<td align="center">'. $row[3] . "</td>";
                        Print '<td align="center">'. $row[4] . "</td>";
						Print '<td align="center">'. $row[5] . "</td>";
						Print '<td align="center"> <a href ="models\\' . $row[6] . "\\" . $row[6] . '.obj">' . $row[6] . ".obj </a></br>";
						Print '<a href ="models\\' . $row[6] . "\\" . $row[6] . '.mat">' . $row[6] . ".mat </a></br>";
						Print '<a href ="models\\' . $row[6] . "\\" . $row[6] . '.txt">' . $row[6] . ".txt </a></br>";
						Print '<a href ="models\\' . $row[6] . "\\" . $row[6] . '.jpg">' . $row[6] . ".jpg </a></td>";
					Print "</tr>";
                }
			?>
	</table>
</div>

</div>
</div>


</div>




</body>
</html>