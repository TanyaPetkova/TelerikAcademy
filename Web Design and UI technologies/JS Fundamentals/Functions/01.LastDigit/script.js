//Write a function that returns the last digit of given integer as an English word. Examples: 512 -> 'two', 1024 -> 'four', 12309 -> 'nine'

var number,
    word = '',
    message = 'Enter an integer number:';

number = validateInput(number, message);
word = getLastDigit(number);

alert(word);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function getLastDigit(number) {
    switch (number % 10) {
        case 0:
            word = 'zero';
            break;
        case 1:
            word = 'one';
            break;
        case 2:
            word = 'two';
            break;
        case 3:
            word = 'three';
            break;
        case 4:
            word = 'four';
            break;
        case 5:
            word = 'five';
            break;
        case 6:
            word = 'six';
            break;
        case 7:
            word = 'seven';
            break;
        case 8:
            word = 'eight';
            break;
        case 9:
            word = 'nine';
            break;
    }

    return word;
}
