//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

var array,
    keyElement = 0,
    middle;

array = initializeArray();
inputKeyElement();
middle = binarySearch(0, array.length - 1);

alert('The key element ' + keyElement + ' has an index ' + middle + '.');

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

function inputKeyElement(parameters) {
    var isEqual = false;
    while (!isEqual) {
        keyElement = prompt('Choose the key element:');

        for (var i = 0; i < array.length; i += 1) {
            if (keyElement !== array[i]) {
                continue;
            }
            else {
                isEqual = true;
                break;
            }
        }
    }
}

function orderBy(a, b) {
    return (a === b) ? 0 : (a > b) ? 1 : -1;
};

function binarySearch(left, right) {
    array.sort(orderBy);
    while (left <= right) {
        var middle = parseInt((left + right) / 2);
        if (array[middle] === keyElement) {
            return middle;
        }
        else if (array[middle] > keyElement) {
            right = middle - 1;
        } else {
            left = middle + 1;
        }
    }
}