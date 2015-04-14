/*Write a function that makes a deep copy of an object
   - The function should work for both primitive and reference types
*/

var person = buildPerson('Gosho', 'Petrov', 32),
    copiedPerson = deepCopy(person);

console.log(person.toString());
console.log(copiedPerson.toString());

function buildPerson(firstname, lastname, age) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age,
        car: {
            model: 'BMW'
        },
        toString: function () {
            return this.firstname + ' ' + this.lastname + ', ' + age + ' years old, owner of ' + this.car.model;
        }
    }
}

function deepCopy(obj) {
    var copy = new Object();
    for (var key in obj) {
        copy[key] = obj[key];
        if ((typeof copy[key]) == "object") {
            deepCopy(obj[key]);
        }
    }

    return copy;
}