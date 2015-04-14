var drawingModule = (function () {
    var self,
        canvas,
        canvasCtx;

    canvas = document.createElement('canvas');
    canvas.width = 800;
    canvas.height = 600;
    canvasCtx = canvas.getContext('2d');

    document.body.appendChild(canvas);

    function drawRect(x, y, width, height) {
        var rect = new Rect(x, y, width, height);
        rect.draw(canvasCtx);
    }

    function drawCircle(x, y, radius) {
        var circle = new Circle(x, y, radius);
        circle.draw(canvasCtx);
    }

    function drawLine(x1, y1, x2, y2) {
        var line = new Line(x1, y1, x2, y2);
        line.draw(canvasCtx);
    }

    self = {
        drawRect: drawRect,
        drawCircle: drawCircle,
        drawLine: drawLine
    }

    return self;
}());

var Rect = (function () {
    function Rect(x, y, width, height) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    Rect.prototype.draw = function (canvasCtx) {
        canvasCtx.fillRect(this.x, this.y, this.width, this.height);
        canvasCtx.strokeRect(this.x, this.y, this.width, this.height);
        return this;
    }

    return Rect;
}());

var Circle = (function () {
    function Circle(x, y, radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    Circle.prototype.draw = function (canvasCtx) {
        canvasCtx.beginPath();
        var step = 2 * Math.PI / 40;
        for (var angle = 0; angle <= 360; angle += step) {
            var currentX = this.x + this.radius * Math.cos(angle);
            var currentY = this.y - this.radius * Math.sin(angle);

            canvasCtx.lineTo(currentX, currentY);
        }

        canvasCtx.fill();
        canvasCtx.stroke();
        canvasCtx.closePath();

        return this;
    }

    return Circle;
}());

var Line = (function () {
    function Line(x1, y1, x2, y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    Line.prototype.draw = function (canvasCtx) {
        canvasCtx.beginPath();
        canvasCtx.moveTo(this.x1, this.y1);
        canvasCtx.lineTo(this.x2, this.y2);
        canvasCtx.stroke();
        canvasCtx.closePath();

        return this;
    }

    return Line;
}());

drawingModule.drawRect(50, 100, 200, 200);
drawingModule.drawCircle(400, 100, 50);
drawingModule.drawLine(500, 100, 800, 300);