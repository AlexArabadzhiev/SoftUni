<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>MostFrequentTag</title>
</head>
<body>
    <form method="post">
        <input type="text" name="tags" id="tags"/>
        <input type="submit" name="submit" id="submit"/>
        <?php
        if($_POST && isset($_POST["submit"])) {
            $inputArr = explode(", ", $_POST["tags"]);
            $outputArr = array_count_values($inputArr);
            arsort($outputArr);
            echo "<div id='result'>";
            foreach($outputArr as $key => $value){
                if($value > 1) {
                    echo $key . " : " . $value . " times" . "<br />";
                }
                else{
                    echo $key . " : " . $value . " time" . "<br />";
                }

            }
            if(array_values($outputArr)[0] = 1){
                echo "<br /> A most frequent tag doesn't exist.";
            }
            else {
                echo "<br /> Most frequent tag is: " . array_keys($outputArr)[0];
            }
            echo "<div />";
        }
        ?>
    </form>
</body>
</html>