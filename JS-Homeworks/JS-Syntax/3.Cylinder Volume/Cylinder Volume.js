var cyl1 = [2, 4],
    cyl2 = [5, 8],
    cyl3 = [12, 3];

function calcCylinderVol(arr){
    var r = arr[0],
        h = arr[1],
        vol = Math.PI * r * r * h;
    return vol.toFixed(3);
}
console.log(calcCylinderVol(cyl1));
console.log(calcCylinderVol(cyl2));
console.log(calcCylinderVol(cyl3));