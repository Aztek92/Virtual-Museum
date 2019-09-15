<?php 



if($_SERVER['REQUEST_METHOD'] = "POST") {

    $validation = 1;
    $notification = "\r\n";

    $name = mysql_real_escape_string($_POST['name']);
    $description = mysql_real_escape_string($_POST['description']);
    $author = mysql_real_escape_string($_POST['author']);
    $year = mysql_real_escape_string($_POST['year']);
    $museum = mysql_real_escape_string($_POST['museum']);
    $filename = mysql_real_escape_string($_POST['filename']);
    $upload_date = date("Y-m-d H:i:s");



    //VALIDATION
    if(empty($_POST['name']) || strlen($_POST['name']) > 80) {
        $validation = 0;
        $notification = $notification . "\r\nBłędna nazwa";
    }

    if(empty($_POST['description'])) {
        $validation = 0;
        $notification = $notification . "\r\nBłędny opis";
    }

    if(empty($_POST['author']) || strlen($_POST['author']) > 50) {
        $validation = 0;
        $notification = $notification . "\r\nBłędna nazwa autora";
    }

    if(empty($_POST['year']) || strlen($_POST['year']) > 20) {
        $validation = 0;
        $notification = $notification . "\r\nBłędny rok";
    }

    if(empty($_POST['museum']) || strlen($_POST['author']) > 50) {
        $validation = 0;
        $notification = $notification . "\r\nBłędna nazwa muzeum";
    }

    if(is_dir("models/". $filename ."/")) {
       $validation = 0; 
       $notification = $notification . "\r\nNazwa pliku jest zajęta!";
    }


    

    if($validation == 1) {
        if(!is_dir("models/". $filename ."/")) {
            mkdir("models/". $filename ."/");
        }
    

    //UPLOAD MODELU
    $target_dir = "models/" . $filename . "/";
    $target_file = $target_dir . basename($_FILES["objfile"]["name"]);
    $uploadOk = 1;
    $imageFileType = strtolower(pathinfo($target_file,PATHINFO_EXTENSION));
    
    if(isset($_POST["submit"])) {

    }
    if (file_exists($target_file)) {
        $notification =  $notification . "\r\nPlik już istnieje!";
        $uploadOk = 0;
    }
    if ($_FILES["objfile"]["size"] > 500000) {
        $notification =  $notification . "\r\nPlik jest zbyt duży!";
        $uploadOk = 0;
    }
    if($imageFileType != "obj") {
        $notification =  $notification . "\r\nDozwolony format: .obj";
        $uploadOk = 0;
    }
    if ($uploadOk == 0) {
         $notification =  $notification . "\r\nModel nie został wysłany!";
    } else {
        if (move_uploaded_file($_FILES["objfile"]["tmp_name"], $target_dir . $filename . ".obj")) {
            $notification =  $notification . "\r\nModel został poprawnie wysłany!";
        } else {
            $notification = $notification . "\r\nPNie można wyczytac modelu!";
        }
    }

    //UPLOAD TEKSTURY
    $target_dir = "models/" . $filename . "/";
    $target_file = $target_dir . basename($_FILES["matfile"]["name"]);
    $uploadOk = 1;
    $imageFileType = strtolower(pathinfo($target_file,PATHINFO_EXTENSION));
    
    if(isset($_POST["submit"])) {

    }

    if (file_exists($target_file)) {
        $notification =  $notification . "\r\nPlik już istnieje!";
        $uploadOk = 0;
    }
    if ($_FILES["matfile"]["size"] > 500000) {
        $notification =  $notification . "\r\nPlik jest zbyt duży!";
        $uploadOk = 0;
    }
    if($imageFileType != "mat") {
        $notification =  $notification . "\r\nDozwolony format: .mat";
        $uploadOk = 0;
    }
    if ($uploadOk == 0) {
        $notification =  $notification . "\r\nTekstura nie została wysłana!";
    } else {
        if (move_uploaded_file($_FILES["matfile"]["tmp_name"], $target_dir . $filename . ".mat")) {
            $notification =  $notification . "\r\nTekstura została dodana!";
        } else {
            $notification =  $notification . "\r\nTekstura nie została dodana!";
        }
    }

        //UPLOAD OPISU
        $target_dir = "models/" . $filename . "/";
        $target_file = $target_dir . basename($_FILES["txtfile"]["name"]);
        $uploadOk = 1;
        $imageFileType = strtolower(pathinfo($target_file,PATHINFO_EXTENSION));
        
        if(isset($_POST["submit"])) {
    
        }
    
        if (file_exists($target_file)) {
            $notification =  $notification . "\r\nPlik już istnieje!";
            $uploadOk = 0;
        }
        if ($_FILES["txtfile"]["size"] > 500000) {
            $notification =  $notification . "\r\nPlik jest zbyt duży!";
            $uploadOk = 0;
        }
        if($imageFileType != "txt") {
            $notification =  $notification . "\r\nDozwolny format: .txt";
            $uploadOk = 0;
        }
        if ($uploadOk == 0) {
            $notification =  $notification . "\r\nOpis nie został wysłany!";
        } else {
            if (move_uploaded_file($_FILES["txtfile"]["tmp_name"], $target_dir . $filename . ".txt")) {
                $notification =  $notification . "\r\nOpis został dodany!";
            } else {
                $notification =  $notification . "\r\nOpis nie został dodany!";
            }
        }

        //UPLOAD TEKSTURY
        $target_dir = "models/" . $filename . "/";
        $target_file = $target_dir . basename($_FILES["jpgfile"]["name"]);
        $uploadOk = 1;
        $imageFileType = strtolower(pathinfo($target_file,PATHINFO_EXTENSION));
        
        if(isset($_POST["submit"])) {
    
        }
    
        if (file_exists($target_file)) {
            $notification =  $notification . "\r\nPlik już istnieje!";
            $uploadOk = 0;
        }
        if ($_FILES["jpgfile"]["size"] > 500000) {
            $notification =  $notification . "\r\nPlik jest zbyt duży!";
            $uploadOk = 0;
        }
        if($imageFileType != "jpg") {
            $notification =  $notification . "\r\nDozwolony format: .jpg";
            $uploadOk = 0;
        }
        if ($uploadOk == 0) {
            $notification =  $notification . "\r\nPodgląd nie został dodany!";
        } else {
            if (move_uploaded_file($_FILES["jpgfile"]["tmp_name"], $target_dir . $filename . ".jpg")) {
                $notification =  $notification . "\r\nPodgląd został dodany!";
            } else {
                $notification =  $notification . "\r\nPodgląd nie został dodany!";
            }
        }
    


    $db_address = '127.0.0.1';
    $db_name = 'muzeumvr';
    $db_login = 'root';
    $db_password = '';


    mysql_connect($db_address,$db_login,$db_password) or die(mysql_error());
    mysql_select_db($db_name) or die("Nie można połączyć z bazą danych");

   
    mysql_query("INSERT INTO `model` (`name`, `description`, `upload_date`, `author`, `year`, `museum`, `filename`, `verified`) VALUES ('$name','$description', '$upload_date','$author','$year','$museum', '$filename', 0)"); 
    header("location: index.php");

            echo '<script language="javascript">';
            echo 'alert("' . $notification . '")';
            echo '</script>';
    }
    else {

            echo '<script language="javascript">';
            echo 'alert("' . $notification . '")';
            echo '</script>';
    }




    }
    else
    {
        echo '<script language="javascript">';
        echo 'alert("' . $notification . '")';
        echo '</script>';
        header("location:index.php");
    }
?>