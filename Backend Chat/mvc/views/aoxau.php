<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Ao XAU</title>
    <style>
    div{padding:20px}
    #header, #footer{background-color: <?php echo $data["Number"] ?>}
    </style>
</head>
<body>
    <div id="header"></div>
    <div id="content">
        <?php require_once "./mvc/views/pages/".$data["Page"].".php" ?>
        <br/>
        <form action="" method="POST" enctype="multipart/form-data">
            <input type="file" name="HinhAvatar"/>
            <input type="submit" value="post"/>
        </form>
    </div>
    <div id="footer">
    Day la footer
    </div>
</body>
</html>