function area(r){
    var ar =Math.PI*r*r;
    return ar;
}
document.getElementById("7").innerHTML += area(7);
document.getElementById("1.5").innerHTML += area(1.5);
document.getElementById("20").innerHTML += area(20);
