<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Square Root Sum</title>

</head>
<body>
<?php
echo "<table border='1'>"."<tr>"."<td>Number</td>"."<td>Square</td>";
$total = 0;
for($i = 0; $i<=100; $i+=2) {
    $sqr = round(sqrt($i),2);
    $total+=$sqr;
    echo "<tr>" . "<td>" . $i . "</td>" . "<td>" . $sqr . "</td>";
}
echo "<tr>"."<td>Total:</td>"."<td>$total</td>";
echo "<table/>";
?>
</body>
</html>