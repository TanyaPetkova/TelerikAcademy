//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

var number,
    mask = 8,
    inputMessage = 'Enter an integer number:',
    outputMessage = 'The bit 3 (counting from 0) is ';

number = validateInput(inputMessage);
findThirdBit(number);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function findThirdBit(number) {
    if ((number & mask) === mask) {
        alert(outputMessage + 1);
    } else {
        alert(outputMessage + 0);
    }
}