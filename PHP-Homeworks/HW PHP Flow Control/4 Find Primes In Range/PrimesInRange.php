<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Primes in range</title>
</head>
<body>
<form method="get">
    <label for="start">Starting Index: </label>
    <input type="text" name="start"/>
    <label for="end">End:</label>
    <input type="text" name="end"/>
    <input type="submit" name="submit"/><br/>
</form>
<?php
if(isset($_GET['start'], $_GET['end'])){
    $start = intval($_GET['start']);
    $end = intval($_GET['end']);
    function isPrime($n){
        $i = 2;
        if ($n == 2){
            return true;
        }
        while ($i < $n){
            if ($n % $i == 0) {
                return false;
            }
            $i++;
        }
        return true;
    }
    for($i = $start; $i<=$end; $i++){
        if(isPrime($i) && $i > 1){
            if ($i == $end){
                echo "<strong>$i</strong>";
            }
            else {
                echo "<strong>$i</strong>, ";
            }
        }
        else {
            if ($i > 1) {
                if ($i == $end) {
                    echo $i;
                } else {
                    echo $i . ", ";
                }
            }
        }
    }
}
?>
</body>
</html>