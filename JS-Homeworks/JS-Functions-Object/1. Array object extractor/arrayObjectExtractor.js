function extractObjects(args){
    var arr = args;
    var arr2 = [];
    arr.forEach(function(element){
       if(typeof element === 'object' && !Array.isArray(element) )
        arr2.push(element);
    })
    console.log(arr2);
}
extractObjects([
        "Pesho",
        4,
        4.21,
        { name : 'Valyo', age : 16 },
        { type : 'fish', model : 'zlatna ribka' },
        [1,2,3],
        "Gosho",
        { name : 'Penka', height: 1.65}
    ]
)