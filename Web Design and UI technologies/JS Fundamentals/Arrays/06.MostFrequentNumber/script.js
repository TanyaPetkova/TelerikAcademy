/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
*/

var array,
    counter = 1,
    maxFrequency = 0,
    mostFrequentElement,
    equalElements = new Array();

array = initializeArray();
findMostFrequentNumber();
printNumber();

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

function findMostFrequentNumber(parameters) {
    mostFrequentElement = array[0];
    for (var i = 0; i < array.length; i += 1) {
        for (var j = i + 1; j < array.length; j += 1) {
            if (array[i] === array[j]) {
                counter++;
            }
        }

        if (maxFrequency < counter) {
            maxFrequency = counter;
            mostFrequentElement = array[i];
            equalElements = [];
            equalElements.push(array[i]);
        }
        else if (maxFrequency === counter) {
            maxFrequency = counter;
            mostFrequentElement = array[i];
            equalElements.push(array[i]);
        }

        counter = 1;
    }
}

function printNumber(parameters) {
    if (equalElements.length === 1) {
        alert('The most frequent number in the array is ' + mostFrequentElement + '. It appears ' + maxFrequency + ' times.');
    }
    else {
        alert('The most frequent numbers in the array are ' + equalElements.join(', ') + '. They appear ' + maxFrequency + ' times each.');
    }
}

