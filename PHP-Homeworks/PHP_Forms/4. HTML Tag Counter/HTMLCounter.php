<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML Tag Counter</title>
</head>
<body>
    <form method="post">
        <label for="tags">Enter HTML tag: </label><br/>
        <input type="text" name="tags"/>
        <input type="submit" name="submit"/><br/>
    </form>
    <?php
    session_start();
    $validTags = array('a', 'abbr', 'acronym', 'address', 'applet', 'area', 'b', 'base', 'basefont',
        'bdo', 'bgsound', 'big', 'blockquote', 'blink', 'body', 'br', 'button', 'caption', 'center', 'cite', 'code',
        'col', 'colgroup', 'dd', 'dfn', 'del', 'dir', 'dl', 'div', 'dt', 'embed', 'em', 'fieldset', 'font', 'form',
        'frame', 'frameset', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'head', 'hr', 'html', 'iframe', 'img', 'input',
        'ins', 'isindex', 'i', 'kbd', 'label', 'legend', 'li', 'link', 'marquee', 'menu', 'meta', 'noframe',
        'noscript', 'optgroup', 'option', 'ol', 'p', 'pre', 'q', 's', 'samp', 'script', 'select', 'small', 'span', 'strike',
        'strong', 'style', 'sub', 'sup', 'table', 'td', 'th', 'tr', 'tbody', 'textarea', 'tfoot', 'thead', 'title',
        'tt', 'u', 'ul', 'var');
    $counter = 0;
    if(isset($_POST["tags"])){
        if(!isset($_SESSION['counter'])){
            $_SESSION['counter'] = 0;
        }
        if(in_array($_POST["tags"], $validTags)){
            $_SESSION['counter']++;
            echo "Valid HTML Tag!!! <br/>";
            echo "Score: " . $_SESSION['counter'];
        }
        else{
            echo "Invalid HTML Tag!!! <br/>";
            echo "Score: " .  $_SESSION['counter'];
        }
    }
    ?>
</body>
</html>