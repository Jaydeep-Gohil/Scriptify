<?php
    $nm=$_POST['nm'];
    $city=$_POST['city'];
    $gender=$_POST['g'];
    $hobby=$_POST['h'];
    $file=$_FILES['file'];
    echo "Name: $nm <br>";
    echo "City: $city <br>";
    echo "Gender: $gender <br>";
    if(!empty($hobby)){
        foreach($hobby as $h){
            echo "$h ";
        }
    }
?>