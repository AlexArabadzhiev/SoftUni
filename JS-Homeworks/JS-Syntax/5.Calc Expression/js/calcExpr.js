function calc(expr){
    var expr = document.getElementById('expression').value;
    document.getElementById('result').value = eval(expr);
}
