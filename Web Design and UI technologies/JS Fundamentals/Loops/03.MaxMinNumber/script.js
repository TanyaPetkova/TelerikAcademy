//Write a script that finds the max and min number from a sequence of numbers

var count,
    currentNumber,
    maxNumber,
    minNumber;

count = prompt('Enter the count of numbers:');
findMaxMinNumber(currentNumber, count);

function isNumber(value) {
    return !isNaN(value);
}

function validateInput(message) {
    do {
        currentNumber = prompt(message);
    } while (!isNumber(currentNumber))

    return currentNumber;
}

function findMaxMinNumber(currentNumber, count) {
    for (var i = 0; i < count; i += 1) {
        currentNumber = validateInput('Enter an integer number:');
        currentNumber = parseFloat(currentNumber);

        if (i === 0) {
            maxNumber = minNumber = currentNumber;
        }

        if (currentNumber > maxNumber) {
            maxNumber = currentNumber;
        }

        if (currentNumber < minNumber) {
            minNumber = currentNumber;
        }
    }

    alert('The minimal number is ' + minNumber + ', the maximal number is ' + maxNumber);
}
