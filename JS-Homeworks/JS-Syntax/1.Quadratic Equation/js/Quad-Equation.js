function calcQuad() {
    var a = document.getElementById('a').value;
    var b = document.getElementById('b').value;
    var c = document.getElementById('c').value;

    var d = (Math.pow(b, 2) - (4 * a * c));
    var x1 = (-b + Math.sqrt(d)) / (2 * a);
    var x2 = (-b - Math.sqrt(d)) / (2 * a);
    if (d > 0) {
        x1 = (-b - Math.sqrt(d)) / (2 * a);
        x2 = (-b + Math.sqrt(d)) / (2 * a);
        var res = "x1 = " + x1;
        var res2 = "x2 = " + x2;
        document.getElementById('result').innerHTML = "RESULTS:" + "</br>" + res + "</br>" +res2;
    }

    if (d === 0) {
        x1 = (-b) / (2 * a);
        var res = "x = " + x1;
        document.getElementById('result').innerHTML = "RESULT:" + "</br>" + res;
    }

    if (d < 0) {
        var res = "No real roots";
        document.getElementById('result').innerHTML = res;
    }
}
