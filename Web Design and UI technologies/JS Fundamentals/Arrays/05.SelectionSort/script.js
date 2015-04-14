/*Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. Use the "selection sort" algorithm: 
  Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
  Hint: Use a second array
*/

var array,
    index = 0;

array = initializeArray();
selectionSort();

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

function selectionSort(parameters) {
    console.log(array.join(', '));
    for (var i = 0; i < array.length - 1; i += 1) {
        var minValue = Number.MAX_VALUE;

        for (var j = i; j < array.length; j += 1) {
            if (array[j] < minValue) {
                minValue = array[j];
                index = j;
            }
        }
        array[index] = array[i];
        array[i] = minValue;
        minValue = Number.MAX_VALUE;

        console.log(array.join(', '));
    }
}