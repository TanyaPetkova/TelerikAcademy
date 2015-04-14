/*Write a function that removes all elements with a given value

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];

   - Attach it to the array type
   - Read about prototype and how to attach methods
*/

var array,
    value;

Array.prototype.remove = function (value) {
    var i;
    for (i = 0; i < this.length; i++) {
        if (this[i] === value) {
            this.splice(i, 1);
        }
    }
}

array = initializeArray();
console.log(array);
value = prompt('Enter an elemets value, that want to be removed:');
array.remove(value);
console.log(array);

function initializeArray(parameters) {
    do {
        var arrayLength = prompt('Enter the array\'s length:');
    } while (arrayLength <= 0)

    array = new Array(arrayLength);

    for (var i = 0; i < arrayLength; i += 1) {
        array[i] = prompt('Enter an element of the array: ', i);
    }

    return array;
}


