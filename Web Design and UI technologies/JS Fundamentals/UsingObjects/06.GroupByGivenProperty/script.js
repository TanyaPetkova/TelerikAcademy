/* Write a function that groups an array of persons by age, first or last name. The function must return an associative array, with keys - 
the groups, and values -arrays with persons in this groups
   - Use function overloading (i.e. just one function)

var persons = {…};
var groupedByFname = group(persons, 'firstname');
var groupedByAge= group(persons, 'age');
*/

var persons = [
    buildPerson('Gosho', 'Petrov', 32),
    buildPerson('Pesho', 'Ivanov', 32),
    buildPerson('Pesho', 'Goshov', 45),
    buildPerson('Milka', 'Ivanova', 22),
    buildPerson('Svetla', 'Ivanova', 27),
    buildPerson('Kosta', 'Bakalov', 33)
];

var groupedByFname = group(persons, 'firstname');
console.log('grouped by firstname');
print(groupedByFname);

var groupedByLname = group(persons, 'lastname');
console.log('grouped by lastname');
print(groupedByLname);

var groupedByAge = group(persons, 'age');
console.log('grouped by age');
print(groupedByAge);

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

function group(persons, propertyName) {
    var uniqueValues = [],
        groupedByValues = [],
        groupedByProperty = {},
        i;
    for (i = 0; i < persons.length; i += 1) {
        if (uniqueValues.indexOf(persons[i][propertyName]) === -1) {
            uniqueValues.push(persons[i][propertyName]);
        }
    }

    for (var j = 0; j < uniqueValues.length; j += 1) {
        for (var k = 0; k < persons.length; k++) {
            if (uniqueValues[j] === persons[k][propertyName]) {
                groupedByValues.push(persons[k]);
            }
        }

        groupedByProperty[uniqueValues[j]] = groupedByValues;
        groupedByValues = [];
    }

    return groupedByProperty;
}

function print(groupedBy) {
    for (var i in groupedBy) {
        console.log('grouped by ' + i);
        for (var j = 0; j < groupedBy[i].length; j += 1) {
            console.log(groupedBy[i][j].toString());
        }
    }
    console.log('\n');
}
