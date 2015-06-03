function solve(arg) {
    var arr = arg;
    var numArr = arr.filter(function (element) {
        return !isNaN(element);
    }).sort(function (x, y) {
        return x < y;
    })
    var minNum = numArr[numArr.length - 1];
    var maxNum = numArr[0];
    var mostFrNum = null;
    var count = 0;
    for (var i = 0; i < numArr.length - 1; i++) {
        var count2 = 0;
        for (var j = 1; j < numArr.length; j++) {
            if (numArr[j] == numArr[i]) {
                count2++;
            }
        }
        if (count2 > count) {
            mostFrNum = numArr[i];
        }
    }
    console.log('Min number: ' + minNum);
    console.log('Max number: ' + maxNum);
    console.log('Most frequent number: ' + mostFrNum);
    console.log(numArr);
}
solve( ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0,
    "Penka", {bunniesCount: 10}, [10, 20, 30, 40]])