//Write an expression that calculates trapezoid's area by given sides a and b and height h.

var sideA,
    sideB,
    height,
    area,
    outputMessage = 'The trapezoid\'s area is ';

sideA = validateInput(sideA, 'Enter the length of the side a:');
sideB = validateInput(sideB, 'Enter the length of the side b:');
height = validateInput(height, 'Enter the length of the height:');

area = calcTrapezoidArea(sideA, sideB, height);
alert(outputMessage + area);

function isNumber(value) {
    return !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isNumber(number))

    return number;
}

function calcTrapezoidArea(sideA, sideB, height) {
    return (parseInt(sideA) + parseInt(sideB)) * height / 2;
}