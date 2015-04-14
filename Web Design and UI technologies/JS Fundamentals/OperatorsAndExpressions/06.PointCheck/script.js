//Write an expression that checks if given print (x, y) is within a circle K(O, 5).

var xCoordinate,
    yCoordinate,
    radius = 5;

xCoordinate = validateInput(xCoordinate, 'Enter enter a point of abscissa:');
yCoordinate = validateInput(yCoordinate, 'Enter enter a point of ordinate:');
checkPoint(xCoordinate, yCoordinate);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function checkPoint(xCoordinate, yCoordinate) {
    if (xCoordinate*xCoordinate + yCoordinate*yCoordinate <= radius * radius) {
        alert('The point (' + xCoordinate + ', ' + yCoordinate + ') is is within the circle K(0,5).');
    } else {
        alert('The point (' + xCoordinate + ', ' + yCoordinate + ') is is outside the circle K(0,5).');
    }
}