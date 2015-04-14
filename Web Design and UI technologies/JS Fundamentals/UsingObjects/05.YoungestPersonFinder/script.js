/* Write a function that finds the youngest person in a given array of persons and prints his/hers full name
   - Each person have properties firstname, lastname and age, as shown:

   var persons = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
*/

var persons = [
        { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
        { firstname: 'Bay', lastname: 'Ivan', age: 81 },
        { firstname: 'Pesho', lastname: 'Goshov', age: 45 },
        { firstname: 'Milka', lastname: 'Ivanova', age: 22 },
        { firstname: 'Svetla', lastname: 'Petkova', age: 27 }
    ],
    youngestPerson = findYoungestPerson(persons);

alert('The youngest person is ' + youngestPerson);


function findYoungestPerson(persons) {
    var minAge = 120,
        position = -1,
        youngestPersonName;
    for (var i in persons) {
        if (persons[i].age < minAge) {
            minAge = persons[i].age;
            position = i;
        }
    }

    youngestPersonName = persons[position].firstname + ' ' + persons[position].lastname;
    return youngestPersonName;
}