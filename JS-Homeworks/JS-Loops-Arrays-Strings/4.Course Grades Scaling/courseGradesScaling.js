function solve(args){
    var  arr = args;
    for (var i = 0; i < arr.length; i++) {
       arr[i].score += arr[i].score /100 *10;

    }
    arr = arr.filter(function(element){
       if(element.score>=100){
           element.hasPassed = true;
           return element;
       }
    }).sort(function(x,y){
        return x.name> y.name;
    })
    console.log(arr)
}

solve([
    {
        'name' : 'Пешо',
        'score' : 91
    },
    {
        'name' : 'Лилия',
        'score' : 290
    },
    {
        'name' : 'Алекс',
        'score' : 343
    },
    {
        'name' : 'Габриела',
        'score' : 400
    },
    {
        'name' : 'Жичка',
        'score' : 70
    }
])