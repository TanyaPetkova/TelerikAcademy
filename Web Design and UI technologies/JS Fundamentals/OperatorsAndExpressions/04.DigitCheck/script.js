//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

var number,
    numberSeven = '7',
    inputMessage = 'Enter an integer number:';

number = validateInput(number, inputMessage);
checkThirdDigit(number);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function checkThirdDigit(number) {
    if (number.toString().charAt(number.length - 3) === numberSeven) {
        alert('Third digit (right-to-left) of the number ' + number + ' is 7.');
    }
    else {
        alert('Third digit (right-to-left) of the number ' + number + ' is NOT 7.');
    }
}
