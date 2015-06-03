function solve(arg){
    var inputSTR = arg;
    var indexCloseA;
    for (var i = 0; i < inputSTR.length; i++) {
        if(inputSTR[i]=='<' && inputSTR[i+1]=='a'){
            for (var j = i; j < inputSTR.length; j++) {
                if(inputSTR[j]=='>'){
                    indexCloseA =j;
                    break;
                }
            }
            break;
        }
    }
    inputSTR = inputSTR.substr(0, indexCloseA) + ']' + inputSTR.substr(indexCloseA+1, inputSTR.length);
    inputSTR = inputSTR.replace('<a', '[URL');
    inputSTR = inputSTR.replace('</a>', '[/URL]');
    console.log(inputSTR)
}
solve('<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>')