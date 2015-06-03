<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PrintTags</title>
</head>
<body>
    <form method="post">
        <input type="text" name="tags" id="tags"/>
        <input type="submit" name="submit" id="submit"/>
        <?php
        if($_POST && isset($_POST["submit"])){
            $tags = explode(", ", $_POST["tags"]);
            echo "<div id='result'>";
            foreach($tags as $key => $value){
                echo $key . " : " . $value. "<br/>";
            }
            echo "<div/>";
        }
        ?>
    </form>
</body>
</html>