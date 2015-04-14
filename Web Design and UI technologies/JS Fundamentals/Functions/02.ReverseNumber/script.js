//Write a function that reverses the digits of given decimal number. Example: 256 -> 652

var number,
    reversedNumber = '',
    message = 'Enter an integer number:';

number = validateInput(number, message);
reverseNumber = reverseNumber(number);

alert(reverseNumber);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function reverseNumber(number) {
    reverseNumber = '';
    for (var i = number.length - 1; i >= 0; i--) {
        reverseNumber += number[i];
    }

    return reverseNumber;
}