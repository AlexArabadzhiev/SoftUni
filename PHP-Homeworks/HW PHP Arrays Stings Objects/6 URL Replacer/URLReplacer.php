<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>URL Replacer</title>
    <style>
        #output{
            width: 500px;
            border: 3px solid dodgerblue;
            border-radius: 10px;
        }
    </style>
</head>
<body>
<form method="get">
    <textarea name="text" id="text" cols="30" rows="10"></textarea><br/>
    <input type="submit" name="submit" value="Replace"/><br/>
</form>
<?php
if(isset($_GET['text'])){
    $text = $_GET['text'];
    $pattern = '/<a href=[\'\"]([^<>]+)[\'\"]>([^<>]+)<\/a>/i';
    preg_match_all($pattern, $text, $matches);
    $text = htmlentities(preg_replace($pattern, '[URL=$1]$2[/URL]', $text));
    echo "<div id='output'>$text</div>";

}
?>
</body>
</html>