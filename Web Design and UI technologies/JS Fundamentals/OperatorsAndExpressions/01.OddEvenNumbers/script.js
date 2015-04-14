//Write an expression that checks if given integer is odd or even.

var number,
    inputMessage = 'Enter an integer number:';

number = validateInput(number, inputMessage);
parityCheck(number);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}


function parityCheck(number) {
    if (number % 2 === 0) {
        alert('The number ' + number + ' is even.');
    } else {
        alert('The number ' + number + ' is odd.');
    }
}