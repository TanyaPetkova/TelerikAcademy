//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var number,
    numberSeven = 7,
    numberFive = 5,
    inputMessage = 'Enter an integer number:';

number = validateInput(number, inputMessage);
divisibilityCheck(number);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function divisibilityCheck(number) {
    if (number % (numberSeven * numberFive) === 0) {
        alert('The integer number ' + number + ' can be devided (without remainder) by 7 and 5 in the same time.');
    } else {
        alert('The integer number ' + number + ' CANNOT be devided (without remainder) by 7 and 5 in the same time.');
    }
}