/*Write a function that checks if a given object contains a given property

var obj  = …;
var hasProp = hasProperty(obj, 'length');
*/

var person = buildPerson('Gosho', 'Petrov', 32);

var hasProp = hasProperty(person, 'firstname'); //true
console.log(hasProp);

hasProp = hasProperty(person, 'middlename'); //false
console.log(hasProp);

function buildPerson(firstname, lastname, age) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age,
        toString: function () {
            return this.firstname + ' ' + this.lastname + ', ' + age + ' years old';
        }
    }
}

function hasProperty(obj, property) {
    var hasProp = false;
    if (obj[property]) {
        hasProp = true;
    }
    return hasProp;
}