var canvas = document.getElementById('the-canvas');
var canvasCtx = canvas.getContext('2d');

drawHouse();
drawBicycle();
drawHead();

function drawBicycle() {
    var startX = 20,
        startY = 1200;

    //draw wheels
    drawEllipse(canvasCtx, startX + 90, startY + 90, 95, 90, 0, 2 * Math.PI, true, '#90CAD7', '#22545F');
    drawEllipse(canvasCtx, startX + 440, startY + 90, 95, 90, 0, 2 * Math.PI, true, '#90CAD7', '#22545F');

    //draw frame
    canvasCtx.beginPath();

    canvasCtx.moveTo(startX + 90, startY + 90);
    canvasCtx.lineTo(startX + 205, startY - 30);
    canvasCtx.lineTo(startX + 425, startY - 30);
    canvasCtx.lineTo(startX + 260, startY + 85);
    canvasCtx.closePath();

    canvasCtx.moveTo(startX + 440, startY + 90);
    canvasCtx.lineTo(startX + 420, startY - 90);
    canvasCtx.lineTo(startX + 470, startY - 150);

    canvasCtx.moveTo(startX + 420, startY - 90);
    canvasCtx.lineTo(startX + 345, startY - 65);

    canvasCtx.moveTo(startX + 260, startY + 85);
    canvasCtx.lineTo(startX + 180, startY - 70);
    canvasCtx.lineTo(startX + 220, startY - 70);
    canvasCtx.lineTo(startX + 140, startY - 70);

    canvasCtx.moveTo(startX + 230, startY + 60);
    canvasCtx.lineTo(startX + 210, startY + 40);

    canvasCtx.moveTo(startX + 285, startY + 115);
    canvasCtx.lineTo(startX + 305, startY + 135);

    canvasCtx.strokeStyle = '#22545F';
    canvasCtx.stroke();

    canvasCtx.closePath();

    drawEllipse(canvasCtx, startX + 260, startY + 85, 40, 40, 0, 2 * Math.PI, false, '#000', '#22545F');
}

function drawHead() {
    var startX = 20,
        startY = 850;

    //draw the head
    drawEllipse(canvasCtx, startX + 110, startY + 90, 110, 90, 0, 2 * Math.PI + 1, true, '#90CAD7', '#22545F');

    //draw the hat brim
    drawEllipse(canvasCtx, startX + 110, startY, 122, 22, 0, 2 * Math.PI + 1, true, '#396693', '#000');

    //draw the hat cylinder
    drawEllipse(canvasCtx, startX + 110, startY - 24, 62, 20, Math.PI, 2 * Math.PI, true, '#396693', '#000');

    canvasCtx.fillRect(startX + 48, startY - 24 - 115, 124, 115);

    canvasCtx.beginPath();

    canvasCtx.moveTo(startX + 220 / 2 - 62, startY - 24);
    canvasCtx.lineTo(startX + 220 / 2 - 62, startY - 24 - 115);

    canvasCtx.moveTo(startX + 220 / 2 + 62, startY - 24);
    canvasCtx.lineTo(startX + 220 / 2 + 62, startY - 24 - 115);

    canvasCtx.strokeStyle = '#000';
    canvasCtx.stroke();

    canvasCtx.closePath();

    drawEllipse(canvasCtx, startX + 220 / 2, startY - 24 - 115, 62, 20, 0, 2 * Math.PI, true, '#396693', '#000');

    //draw the left eye
    drawEllipse(canvasCtx, startX + 50, startY + 50, 17, 11, 0, 2 * Math.PI, true, '#90CAD7', '#22545F');
    drawEllipse(canvasCtx, startX + 45, startY + 50, 4, 9, 0, 2 * Math.PI, true, '#22545F', '#22545F');

    //draw the right eye
    drawEllipse(canvasCtx, startX + 50 + 75, startY + 50, 17, 11, 0, 2 * Math.PI, true, '#90CAD7', '#22545F');
    drawEllipse(canvasCtx, startX + 50 + 70, startY + 50, 4, 9, 0, 2 * Math.PI, true, '#22545F', '#22545F');

    //draw the nose
    canvasCtx.beginPath();

    canvasCtx.moveTo(startX + 50 + 40, startY + 50);
    canvasCtx.lineTo(startX + 50 + 40 - 30, startY + 50 + 50);
    canvasCtx.lineTo(startX + 50 + 40, startY + 50 + 50);

    canvasCtx.strokeStyle = '#22545F';
    canvasCtx.stroke();
    canvasCtx.closePath();

    //draw mouth
    canvasCtx.rotate(6 * Math.PI / 180);
    drawEllipse(canvasCtx, startX + 50 + 140, startY + 50 + 50 + 20, 40, 12, 0, 2 * Math.PI, true, '#90CAD7', '#22545F', true);
}

function drawHouse() {
    var rectangle = {
        width: 445,
        height: 335
    }

    //house top left corner coordinates
    var startX = 10,
        startY = 300;

    var chimneyWidth = 50,
        chimneyHeight = 130,
        smallRectWidth = 80,
        smallRectHeight = 50;

    //draw the roof
    canvasCtx.beginPath();
    canvasCtx.moveTo(startX, startY);
    canvasCtx.lineTo(startX + rectangle.width / 2, startY - 245);
    canvasCtx.lineTo(startX + rectangle.width, startY);
    canvasCtx.lineWidth = 5;
    canvasCtx.stroke();
    canvasCtx.fillStyle = '#975B5B';
    canvasCtx.fill();

    //draw the chimney
    drawRect(canvasCtx, startX + 310, startY - 60 - chimneyHeight, chimneyWidth, chimneyHeight);

    //remove chimney bottom line
    canvasCtx.beginPath();
    canvasCtx.moveTo(startX + 308, startY - 60);
    canvasCtx.lineTo(startX + 308 + chimneyWidth + 5, startY - 60);
    canvasCtx.lineWidth = 5;
    canvasCtx.strokeStyle = '#975B5B';
    canvasCtx.stroke();

    //draw the cimpney top
    drawEllipse(canvasCtx, startX + 310 + chimneyWidth / 2, startY - 60 - chimneyHeight, chimneyWidth / 2, 5, 0, 2 * Math.PI, true, '#975B5B', '#000');

    //draw the basis of the house
    canvasCtx.fillStyle = '#975B5B';
    canvasCtx.strokeStyle = '#000';
    drawRect(canvasCtx, startX, startY, rectangle.width, rectangle.height);

    //draw the window in the left
    canvasCtx.fillStyle = '#000';
    canvasCtx.strokeStyle = '#975B5B';
    drawRect(canvasCtx, startX + 30, startY + 40, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + smallRectWidth, startY + 40, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30, startY + 40 + smallRectHeight, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + smallRectWidth, startY + 40 + smallRectHeight, smallRectWidth, smallRectHeight);

    //draw the window in the right top
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60, startY + 40, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60 + smallRectWidth, startY + 40, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60, startY + 40 + smallRectHeight, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60 + smallRectWidth, startY + 40 + smallRectHeight, smallRectWidth, smallRectHeight);

    //draw the windod in the right bottom
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60, startY + 40 + 2 * smallRectHeight + 40, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60 + smallRectWidth, startY + 40 + 2 * smallRectHeight + 40, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60, startY + 40 + 50 + 50 + 40 + smallRectHeight, smallRectWidth, smallRectHeight);
    drawRect(canvasCtx, startX + 30 + 2 * smallRectWidth + 60 + smallRectWidth, startY + 40 + 2 * smallRectHeight + 40 + smallRectHeight, smallRectWidth, smallRectHeight);

    //draw the door
    drawEllipse(canvasCtx, startX + 30 + smallRectWidth, startY + 40 + smallRectHeight + smallRectHeight + 70, 60, 35, 0, Math.PI, true, '#975B5B', '#000');
    canvasCtx.beginPath();

    canvasCtx.moveTo(startX + 30 + smallRectWidth - 60, startY + 40 + smallRectHeight + 120);
    canvasCtx.lineTo(startX + 50, startY + rectangle.height);

    canvasCtx.moveTo(startX + 30 + smallRectWidth, startY + 40 + smallRectHeight + 85);
    canvasCtx.lineTo(startX + 50 + 60, startY + rectangle.height);

    canvasCtx.moveTo(startX + 30 + smallRectWidth + 60, startY + 40 + smallRectHeight + 120);
    canvasCtx.lineTo(startX + 50 + 120, startY + rectangle.height);

    canvasCtx.strokeStyle = '#000';
    canvasCtx.stroke();

    //draw the door hanndles
    drawEllipse(canvasCtx, startX + 50 + 45, startY + 40 + smallRectHeight + 85 + 110, 6, 6, 0, 2 * Math.PI + 1, true, '#975B5B', '#000');
    drawEllipse(canvasCtx, startX + 50 + 45 + 30, startY + 40 + smallRectHeight + 85 + 110, 6, 6, 0, 2 * Math.PI + 1, true, '#975B5B', '#000');
}

function drawRect(canvasCtx, x, y, width, height) {
    canvasCtx.lineWidth = 3;

    canvasCtx.fillRect(x, y, width, height);
    canvasCtx.strokeRect(x, y, width, height);
}

/*centerX - x coordinate of the ellipse center
  centerY - y coordinate of the ellipse center
  bigRadius - the biggest ellipse radius
  smallRadius - the smalles ellipse radius 
*/
function drawEllipse(canvasCtx, centerX, centerY, bigRadius, smallRadius, from, to, isFilled, fillColor, strokeColor) {
    canvasCtx.beginPath();
    var step = 2 * Math.PI / 40;
    for (var angle = from; angle <= to; angle += step) {
        var currentX = centerX + bigRadius * Math.cos(angle);
        var currentY = centerY - smallRadius * Math.sin(angle);

        canvasCtx.lineTo(currentX, currentY);

    }

    canvasCtx.lineWidth = 3;
    if (isFilled) {
        canvasCtx.fillStyle = fillColor;
        canvasCtx.fill();
    }

    canvasCtx.strokeStyle = strokeColor;
    canvasCtx.stroke();
    canvasCtx.closePath();
}