<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Sum of digits</title>
</head>
<body>
<form method="get">
    <label for="digits">Input String: </label>
    <input type="text" name="digits" />
    <input type="submit" name="submit" />
</form>
<?php
    if(isset($_GET['digits'])){
        $numbersArr = explode(", ", $_GET['digits']);
        echo "<table border='1'>";
        foreach($numbersArr as $number){
            echo "<tr><td>$number</td>";
            $sum = 0;
            if(is_numeric($number)) {
                for ($i = 0; $i < strlen($number); ++$i) {
                    $sum += $number[$i];
                }
                echo "<td>$sum</td>";
            }
            else{
                echo "<td>I can't sum that!</td>";
            }
        }
        echo "</table>";
    }
?>
</body>
</html>