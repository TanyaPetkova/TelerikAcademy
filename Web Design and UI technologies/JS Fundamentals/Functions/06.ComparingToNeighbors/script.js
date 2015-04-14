//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

var array,
    position;

array = initializeArray();
position = prompt('Enter a position to check:');

if (isGreaterThanNeighbors(array, position)) {
    alert('The element ' + array[position] + ', which is at position ' + position + ' is bigger than its neighbors.');
}
else {
    alert('The element ' + array[position] + ', which is at position ' + position + ' is NOT bigger than its neighbors.');
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

function isGreaterThanNeighbors(array, givenPosition) {
    givenPosition = parseInt(givenPosition);
    if (givenPosition !== 0 && givenPosition !== array.length - 1 && array[givenPosition] > array[givenPosition - 1] && array[givenPosition] > array[givenPosition + 1]) {
        return true;
    } else {
        return false;
    }
}
