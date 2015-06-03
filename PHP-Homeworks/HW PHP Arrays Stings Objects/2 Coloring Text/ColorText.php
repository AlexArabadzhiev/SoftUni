<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Coloring Text</title>
</head>
<body>
<form method="get">
    <textarea name="words" id="text" cols="30" rows="1"></textarea><br/>
    <input type="submit" name="submit" value="Color Text"/>
</form>
</body>
<?php
if(isset($_GET['words']) && !empty($_GET['words'])){
    $text = $_GET['words'];
    preg_match_all('/\S/', $text, $words);

    foreach($words[0] as $letter){
        if(ord($letter) %2 ==0){
            echo "<span style='color:red'>$letter </span>";
        }
        else{
            echo "<span style='color:blue'>$letter </span>";
        }
    }

}
?>
</html>