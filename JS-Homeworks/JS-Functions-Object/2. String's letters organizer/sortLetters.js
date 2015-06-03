function sortLetters(string, boolean){
    var strArr = string.split('');
    strArr.sort(function(x, y){
        if(boolean) {
            return x.toLowerCase() > y.toLowerCase();
        }
        else{
            return x.toLowerCase() < y.toLowerCase();
        }
    })
    var sortedStr = '';
    for (var i = 0; i <strArr.length; i++) {
        sortedStr += strArr[i];

    }
    console.log(sortedStr);
}
sortLetters('HelloWorld', true);
sortLetters('HelloWorld', false);