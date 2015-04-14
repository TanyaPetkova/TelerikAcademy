//Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.

var array,
    number,
    message = 'Enter a number to be counted:',
    count = 0;

array = initializeArray();
number = prompt(message);
count = countNumber(array, number);

alert('The number ' + number + ' appears ' + count + ' times in that array.');

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

function countNumber(array, number) {
    for (var i = 0; i < array.length; i += 1) {
        if (array[i] === number) {
            count++;
        }
    }

    return count;
}
