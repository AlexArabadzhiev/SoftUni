<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Sentence Extractor</title>
</head>
<body>
<form method="get">
    <textarea name="text" id="text" cols="30" rows="10"></textarea><br/>
    <input type="text" name="word"/>
    <input type="submit" name="submit" value="Extract"/><br/>
</form>
<?php
if(isset($_GET['text'], $_GET['word'])){
    $text = $_GET['text'];
    $word = $_GET['word'];

    $pattern = '/[^\.\?!]*(\b'.$word.'\b)[^\.\?!]*[\.\?!]( |$)/i';
    preg_match_all($pattern, $text, $matches);

    echo "<table border='1'>";
    foreach($matches[0] as  $found){
        echo "<tr><td>$found</td></tr>";
    }
    echo "</tablle>";
}
?>
</body>
</html>