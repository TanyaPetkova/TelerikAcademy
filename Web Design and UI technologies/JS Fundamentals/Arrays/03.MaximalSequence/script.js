/*Write a script that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
*/

var array,
    pointer,
    currentLength = 1,
    maxLength = 0,
    elements = new Array();

array = initializeArray();
findMaxSequence();
printSequence();

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

function checkLength(index) {
    if (maxLength < currentLength) {
        maxLength = currentLength;
        elements = [];
        elements.push(array[index - 1]);
    }
    else if (maxLength === currentLength) {
        elements.push(array[index - 1]);
    }
}

function findMaxSequence(parameters) {
    pointer = array[0];

    for (var i = 1; i < array.length; i += 1) {
        if (pointer === array[i]) {
            currentLength++;
        }
        else {
            pointer = array[i];
            checkLength(i);

            currentLength = 1;
        }
    }

    checkLength(array.length);
}

function printSequence(parameters) {
    if (elements.length === 1) {
        console.log('There is one sequence of equal elements with maximal length: ');
    }
    else {
        console.log('There are ' + elements.length + ' sequences of equal elements with maximal length: ');
    }

    for (var index in elements) {
        var maxSequence = new Array(maxLength);

        for (var i = 0; i < maxLength; i += 1) {
            maxSequence[i] = elements[index];
        }

        console.log(maxSequence.join(', '));
    }
}