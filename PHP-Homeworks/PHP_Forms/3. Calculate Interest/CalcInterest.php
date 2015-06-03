<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Calculate Interest</title>
</head>
<body>
<form method="post">
    <label for="inputMoney">Enter Amount</label>
    <input type="text" name="inputMoney"/><br/>
    <input type="radio" name="currency" value="usd"/>
    <label for="usd">USD</label>
    <input type="radio" name="currency" value="eur"/>
    <label for="eur">EUR</label>
    <input type="radio" name="currency" value="bgn"/>
    <label for="bgn">BGN</label><br/>
    <label for="interestRate">Compound Interest Rate</label>
    <input type="text" name="interestRate"/><br/>
    <select name="period" id="period">
        <option value="6months">6 Months</option>
        <option value="1year">1 Year</option>
        <option value="2years">2 Years</option>
        <option value="5years">5 Years</option>
    </select>
    <input type="submit" name="submit" value="Calculate"/>
    <?php
   if(isset($_POST["submit"])) {
       if (isset($_POST["inputMoney"]) && isset($_POST["currency"]) && isset($_POST["interestRate"]) && isset($_POST["period"])) {
           $money = $_POST["inputMoney"];
           $currency = $_POST["currency"];
           $interestRate = $_POST["interestRate"];
           $period = $_POST["period"];
           if ($period == "6months") {
               $period = 6;
           } else if ($period == "1year") {
               $period = 12;
           } else if ($period == "2years") {
               $period = 24;
           } else {
               $period = 60;
           }
           $result = round($money * pow(1 + (($interestRate / 100) / 12), $period / 12 * 12), 2);
           if ($currency == "usd") {
               echo "$ " . $result;
           } else if ($currency == "eur") {
               echo "&#8364; " . $result;
           } else {
               echo "BGN " . $result;
           }

       }
   }
    ?>
    

</form>
</body>
</html>