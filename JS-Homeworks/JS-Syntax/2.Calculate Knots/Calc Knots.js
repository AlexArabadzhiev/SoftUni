function calcKnots(km){
    var knots = km * 0.5399568034557235;
    return knots.toFixed(2);
}
console.log(calcKnots(20));
console.log(calcKnots(112));
console.log(calcKnots(400));