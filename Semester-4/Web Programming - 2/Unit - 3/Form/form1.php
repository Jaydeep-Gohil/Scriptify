<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="form2.php" method="post" enctype="multipart/form-data">
        Name <input type="TEXT" name="nm"><br><br>
        City
        <select name="city">
            <option value="Rajkot">Rajkot</option>
            <option value="Chotila">Chotila</option>
            <option value="Surat">Surat</option>
        </select><br><br>
        Gender
        <input type="radio" name="g" value="Male">Male
        <input type="radio" name="g" value="Female">Female <br><br>
        Hobby
        <input type="checkbox" name="h[]" value="Cricket">Cricket
        <input type="checkbox" name="h[]" value="Reading">Reading
        <input type="checkbox" name="h[]" value="Travelling">Travelling <br><br>
        Upload image
        <input type="file" name="file" id="file"><br><br>
        <input type="submit" name="submit">

    </form>
</body>
</html>