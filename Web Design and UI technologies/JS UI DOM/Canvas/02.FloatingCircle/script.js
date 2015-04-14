var canvas = document.getElementById("the-canvas");
var ctx = canvas.getContext("2d");
var currentX = 50,
    currentY = 250,
    directionByX = 1,
    directionByY = 1,
    ctxWidth = document.getElementById("the-canvas").getAttribute("width"),
    ctxHeight = document.getElementById("the-canvas").getAttribute("height"),
    counter = 1,
    radius = 10;

setInterval(float, 5);

function float() {
    ctx.beginPath();
    ctx.clearRect(0, 0, ctxWidth, ctxHeight);

    currentX += directionByX;
    currentY += directionByY;

    ctx.arc(currentX, currentY, radius, 0, 2 * Math.PI);
    if (currentX > ctxWidth - 3 || currentX < 0) {
        directionByX *= -1;
    }

    if (currentY > ctxHeight || currentY < 1) {
        directionByY *= -1;
    }

    ctx.fillStyle = 'red';
    ctx.fill();

    ctx.closePath();
}