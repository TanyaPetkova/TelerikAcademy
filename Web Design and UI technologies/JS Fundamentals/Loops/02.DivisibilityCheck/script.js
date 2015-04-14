//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var count,
    numberThree = 3,
    numberSeven = 7,
    message = 'Enter a positive integer number:';

count = validateInput(count, message);
printNumbers(count);

function isPositiveInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value) && value > 1;
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isPositiveInt(number))

    return number;
}

function printNumbers(count) {
    for (var i = 1; i <= count; i += 1) {
        if (i  % (numberThree * numberSeven)) {
            console.log(i);
        }
    }
}