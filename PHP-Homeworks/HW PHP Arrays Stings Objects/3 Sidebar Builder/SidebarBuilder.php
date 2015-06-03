<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Sidebar Builder</title>
    <style>
        aside{
            border: 2px solid darkblue;
            border-radius: 10px;
            width: 200px;
            margin-top: 10px;
            margin-bottom: 10px;
            margin-left: 5px;
            background: #26c2ff;
        }
        ul{
            list-style: circle;
        }
        aside h1{
            text-align: center;
            border-bottom: 1px solid darkcyan;
        }
    </style>
</head>
<body>
<form method="get">
    <label for="categories">Categories: </label>
    <input type="text" name="categories" id="categories"><br>
    <label for="tags">Tags: </label>
    <input type="text" name="tags" id="tags"><br>
    <label for="months">Months: </label>
    <input type="text" name="months" id="months"><br>
    <input type="submit" value="Generate">
</form>
<?php
    if(isset($_GET['categories'], $_GET['tags'], $_GET['months'])){
        $categories = explode(', ', $_GET['categories']);
        $tags = explode(', ', $_GET['tags']);
        $months = explode(', ', $_GET['months']);
?>
<aside>
    <h1>Categories</h1>
    <ul>
        <?php foreach ($categories as $category): ?>
            <li><a href="#"><?= $category ?></a></li>
        <?php endforeach; ?>
    </ul>
</aside>
<aside>
    <h1>Tags</h1>
    <ul>
        <?php foreach ($tags as $tag): ?>
            <li><a href="#"><?= $tag ?></a></li>
        <?php endforeach; ?>
    </ul>
</aside>
<aside>
    <h1>Months</h1>
    <ul>
        <?php foreach ($months as $month): ?>
            <li><a href="#"><?= $month ?></a></li>
        <?php endforeach; ?>
    </ul>
</aside>
<?php
    }
?>
</body>
</html>