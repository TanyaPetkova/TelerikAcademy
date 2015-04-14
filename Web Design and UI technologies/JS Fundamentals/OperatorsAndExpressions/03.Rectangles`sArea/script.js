//Write an expression that calculates rectangle’s area by given width and height.

var width,
    height,
    area,
    identifier,
    inputMessage = 'Enter a rectangle\'s ',
    outputMessage = 'The rectangle\'s area is ';

width = validateInput(width, inputMessage);
height = validateInput(height, inputMessage);
area = calcRectangleArea(width, height);

alert(outputMessage + area);

function isNumber(value) {
    return !isNaN(value);
}

function getIdentifier(variable) {
    for (var key in window) {
        if (window[key] === variable)
            return key;
    }
}

function validateInput(number, message) {
    do {
        identifier = getIdentifier(number);
        number = prompt(inputMessage + identifier);
    } while (!isNumber(number))

    return number;
}

function calcRectangleArea(width, height) {
    return width * height;
}
