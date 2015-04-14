//Write a script that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

var array,
    pointer,
    currentLength = 1,
    maxLength = 0,
    indices = new Array();

array = initializeArray();
findMaxIncreasingSequence();
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
        indices = [];
        indices.push(index - 1);
    }
    else if (maxLength === currentLength) {
        indices.push(index - 1);
    }
}

function findMaxIncreasingSequence(parameters) {
    pointer = array[0];

    for (var i = 1; i < array.length; i += 1) {
        if (pointer < array[i]) {
            pointer = array[i];
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
    if (indices.length === 1) {
        console.log('There is one maximal increasing sequence: ');
    }
    else {
        console.log('There are ' + indices.length + ' maximal increasing sequences: ');
    }

    for (var i = 0; i < indices.length; i++) {
        var maxSequence = new Array(maxLength);

        for (var j = maxLength - 1; j >= 0; j--) {
            maxSequence[j] = array[indices[i]];
            indices[i]--;
        }

        console.log(maxSequence.join(', '));
    }
}