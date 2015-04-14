/*Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
   - Use the function from the previous exercise.
*/

var array,
    position;

array = initializeArray();
position = getFirstGreaterThanNeighbors(array);

if (position !== -1) {
    alert('The element ' + array[position] + ', which is at position ' + position + ' is the first element in the array, ' +
'that is bigger than its neighbours.');
}
else {
    alert('There is no element in that array that is bigger than its neightbours.');
}

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

function getFirstGreaterThanNeighbors(array) {
    for (var i = 1; i < array.length - 1; i += 1) {
        if (array[i] > array[i + 1] && array[i] > array[i - 1]) {
            return i;
        }
    }

    return -1;
}