<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Rich People Problems</title>
</head>
<body>
<form method="get">
    <label for="cars">Enter cars</label>
    <input type="text" name="cars"/>
    <input type="submit" name="submit" value="Show Result"/>
</form>
<?php
echo "<br/>";
$colorArr = ["yellow", "blue", "red", "green", "black", "white", "purple", "brown"];
if(isset ($_GET['cars'])){
    if($_GET['cars'] == "" || str_replace(" ", "", $_GET['cars']) == ""){
        echo "Enter car names!";
        return;
    }
    $carsArr = explode(", ", $_GET['cars']);
    echo "<table border='1'>";
    echo "<tr><td><strong>Car</strong></td><td><strong>Color</strong></td><td><strong>Count</strong></td></tr>";
    foreach($carsArr as $car){
        $rand = rand(0,7);
        $count = rand(1,5);
        echo "<tr><td>$car</td><td>$colorArr[$rand]</td><td>$count</td></tr>";
    }
    echo "</table>";
}

?>
</body>
</html>