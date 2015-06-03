<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Annual Expenses</title>
</head>
<body>
<form method="get">
    <label for="years">Enter number of years</label>
    <input type="text" name="years"/>
    <input type="submit" name="submit" value="Show Costs"/>
</form>
<?php
echo "<br/>";
if(isset ($_GET['years'])){
    $count = $_GET['years'];
    if(is_numeric($count) && $count >0 ) {
        $monthsArr = ["January", "February", "March", "April",
                        "May", "June", "July", "August",
                        "September", "October", "November", "December"];

        echo "<table border='1'>";
        echo "<tr><td><strong>Year</strong>";

        foreach($monthsArr as $month){
            echo "</td><td><strong>$month</strong></td>";
        }

        echo "<td><strong>Total:</stong></tr>";

        for ($i = 1; $i <= $count; $i++) {
            $year = 2015 - $i;
            $total = 0;
            echo "<tr><td>$year";
            foreach($monthsArr as $month){
                $rnd = rand(0, 999);
                $total += $rnd;
                echo "</td><td>$rnd</td>";
            }
            echo "<td>$total</tr>";

        }
        echo "</table>";
    }
    else {
        if ($count == "0") {
            echo "Number of years must be at least 1!";
        } else {
            echo "Not a valid number";
        }
    }
}

?>
</body>
</html>