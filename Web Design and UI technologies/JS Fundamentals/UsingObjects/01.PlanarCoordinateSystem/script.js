/*Write functions for working with shapes in  standard Planar coordinate system
   - Points are represented by coordinates P(X, Y)
   - Lines are represented by two points, marking their beginning and ending
       - L(P1(X1,Y1), P2(X2,Y2))
   - Calculate the distance between two points
   - Check if three segment lines can form a triangle
*/

var firstPoint = buildPoint(2, 3),
    secondPoint = buildPoint(-1, 2),
    thirdPoint = buildPoint(1, 5),
    fourthPoint = buildPoint(3, 2),
    fifthPoint = buildPoint(-2, 4),
    sixthPoint = buildPoint(0, 5),
    canFormTriangle;

var firstLine = buildLine(firstPoint, secondPoint);
var secondLine = buildLine(thirdPoint, fourthPoint);
var thirdLine = buildLine(fifthPoint, sixthPoint);

canFormTriangle = checkForTriangle(firstLine, secondLine, thirdLine);

if (canFormTriangle) {
    console.log('The lines ' + firstLine.toString() + ', ' + secondLine.toString() + ', ' + thirdLine.toString() + 'can form a triangle.');
} else {
    console.log('The lines ' + firstLine.toString() + ', ' + secondLine.toString() + ', ' + thirdLine.toString() + 'CANNOT form a triangle.');
}

function buildPoint(x, y) {
    return {
        xCoordinate: x,
        yCoordinate: y,
        toString: function () {
            return '(' + this.xCoordinate + ', ' + this.yCoordinate + ')';
        }
    }
}

function buildLine(startPoint, endPoint) {
    return {
        start: startPoint,
        end: endPoint,
        distance: calculateDistance(startPoint, endPoint),
        toString: function () {
            return 'L(P1' + startPoint.toString() + ', P2' + endPoint.toString() + ')';
        }
    }
}

function calculateDistance(firstPoint, secondPoint) {
    var distance = Math.sqrt((secondPoint.xCoordinate - firstPoint.xCoordinate) * (secondPoint.xCoordinate - firstPoint.xCoordinate) +
        (secondPoint.yCoordinate - firstPoint.yCoordinate) * (secondPoint.yCoordinate - firstPoint.yCoordinate));

    return distance;
}

function checkForTriangle(firtsLine, secondLine, thirdLine) {
    var canFormTriangle = true,
        lines = [firtsLine.distance, secondLine.distance, thirdLine.distance];

    lines.sort(orderBy);
    if (lines[0] + lines[1] <= lines[3]) {
        canFormTriangle = false;
    }

    return canFormTriangle;
}

function orderBy(a, b) {
    return (a == b) ? 0 : (a > b) ? 1 : -1;
};
