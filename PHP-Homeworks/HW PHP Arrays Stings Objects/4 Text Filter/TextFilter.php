<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Text Filter</title>
</head>
<body>
<form method="get">
    <textarea name="text" id="text" cols="30" rows="10"></textarea><br/>
    <input type="text" name="banwords"/>
    <input type="submit" name="submit" value="Replace"/>
</form>
</body>
<?php
if(isset($_GET['text'], $_GET['banwords'])){
    $text = $_GET['text'];
    $ban = explode(", ", $_GET['banwords']);
    foreach($ban as $word){
        $length = str_pad("*", strlen($word), "*");
        $text = str_replace($word, $length, $text);
    }
    echo $text;
}
?>
</html>