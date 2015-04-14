var paper = new Raphael(10, 10, 400, 400);

drawSpiral();

function drawSpiral() {
    var i,
        angle,
        x,
        y;

    for (i = 0; i < 2700; i++) {
        angle = 0.01 * i;
        x = 200 + (5 * angle) * Math.cos(angle);
        y = 150 + (5 * angle) * Math.sin(-angle);
        paper.circle(x, y, 1);
    }
}

