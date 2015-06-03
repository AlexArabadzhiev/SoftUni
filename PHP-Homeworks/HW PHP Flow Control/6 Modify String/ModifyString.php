<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Modify String</title>
</head>
<body>
    <form method="get">
        <input type="text" name="string"/>
        <input type="radio" name="modify" value="palindrome" checked/>
        <label for="palindrome">Check Palindrome</label>
        <input type="radio" name="modify" value="reverse"/>
        <label for="reverse">Reverse String</label>
        <input type="radio" name="modify" value="split"/>
        <label for="split">Split</label>
        <input type="radio" name="modify" value="hash"/>
        <label for="hash">Hash String</label>
        <input type="radio" name="modify" value="shuffle"/>
        <label for="shuffle">Shuffle String</label>
        <input type="submit" name="submit" value="submit"/><br/>
    </form>
<?php
    if(isset($_GET['string'])){

        // Check if string is not empty
        if($_GET['string'] == "" || str_replace(" ", "", $_GET['string']) == ""){
            echo "Enter a string!";
            return;
        }

        $modify = $_GET['modify'];
        $string = $_GET['string'];

        switch($modify){
            case "palindrome":
                $reverse = strrev($string);
                if($reverse == $string){
                    echo "$string is a palindrome!";
                }
                else{
                    echo "$string is not a palindrome!";
                }
                break;
            case "reverse":
                $reverse = strrev($string);
                echo $reverse;
                break;
            case "split":
                $lettersStr = str_replace(" ", "", $string);
                $split = str_split($lettersStr);
                foreach($split as $letter){
                    echo $letter . " ";
                }
                break;
            case "hash":
                echo crypt($string, "RandomSalt");
                break;
            case "shuffle":
                $shuffle = str_shuffle($string);
                echo $shuffle;
                break;
        }
    }
?>
</body>
</html>