//Write a script that finds the greatest of given 5 variables.

var firstNumber,
    secondNumber,
    message = 'Enter a number:';

firstNumber = validateInput(firstNumber, message);

for (var i = 0; i < 5; i++) {
    secondNumber = validateInput(secondNumber, message);
    compare(firstNumber, secondNumber);
}

alert('The greatest number is ' + firstNumber);

function isNumber(value) {
    return !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isNumber(number))

    return number;
}

function compare(firstNumber, secondNumber) {
    if (firstNumber < secondNumber) {
        secondNumber += firstNumber;
        firstNumber = secondNumber - firstNumber;
        secondNumber -= firstNumber;
    }
}

