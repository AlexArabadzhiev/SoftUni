function solve(arg) {
    var arr = arg;
    var validScoreArr = arr.filter(function (element) {
        if (element >= 0 && element <= 400) {
            return element;
        }
    }).sort(function (x, y) {
        return x > y;
    });
    for (var i = 0; i < validScoreArr.length; i++) {
        validScoreArr[i] = validScoreArr[i] - 0.2 * validScoreArr[i];
    }
    console.log(validScoreArr);
}

solve([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1])