<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Word Mapping</title>
</head>
<body>
<form method="get">
    <textarea name="words" id="text" cols="30" rows="1"></textarea><br/>
    <input type="submit" name="submit" value="Count Words"/>
</form>
</body>
<?php
if(isset($_GET['words']) && !empty($_GET['words'])){
    $text = strtolower($_GET['words']);
    $words = preg_split('/[\s,]+/', $text, 0, PREG_SPLIT_NO_EMPTY);
    $map = array_count_values($words);
    echo "<table border='1'>";
    foreach ($map as $word => $count) {
        echo "<tr><td>$word</td><td>$count</td></tr>";
    }
    echo "</table>";
}
?>
</html>