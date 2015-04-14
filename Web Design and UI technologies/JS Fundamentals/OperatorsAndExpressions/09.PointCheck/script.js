/* Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle 
R(top=1, left=-1, width=6, height=2).*/

var xCoordinate,
    yCoordinate,
    radius = 3;

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
    if ((xCoordinate - 1) * (xCoordinate - 1) + (yCoordinate - 1) * (yCoordinate - 1) <= radius * radius) {
        if ((xCoordinate < -1 || xCoordinate > 5) || (yCoordinate > 1 || yCoordinate < -1)) {
            alert('The point (' + xCoordinate + ', ' + yCoordinate + ') is within a circle K((1,1),3) and out of the rectangle R.');
        }
        else {
            alert('The point (' + xCoordinate + ', ' + yCoordinate + ') is within a circle K((1,1),3) and within the rectangle R.');
        }
    }
    else {
        alert('The point (' + xCoordinate + ', ' + yCoordinate + ') is out of the circle K((1,1),3) and out of the rectangle R.');
    }
}