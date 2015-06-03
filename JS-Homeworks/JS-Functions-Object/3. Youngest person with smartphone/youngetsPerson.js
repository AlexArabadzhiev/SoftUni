var people = [{ firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false },
    { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
    { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
    { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }
]
function findYoungestPerson(array){
    var arr = array;
    var outputArr = arr.sort(function(x,y){
        return x.age > y.age;
    }).filter(function(person){
        if(person.hasSmartphone == true){
            return person;
        }
    })

    console.log('The youngest person is ' + outputArr[0].firstname + ' ' + outputArr[0].lastname)
}
findYoungestPerson(people);