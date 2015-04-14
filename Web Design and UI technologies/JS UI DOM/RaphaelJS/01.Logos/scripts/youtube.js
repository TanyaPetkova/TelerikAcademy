var paper = Raphael(10, 10, 500, 500);

//Draw the text 'You Tube'
var you = paper.text(50, 30, "You");
you.scale(0.6, 1);
you.attr({
    "font-weight": "bold",
    "font-size": 70,
    "font-family": "Calibri",
    fill: "#4A4A4A"
});

var tube = paper.text(138, 30, "Tube");
tube.scale(0.6, 1);
tube.attr({
    "font-weight": "bold",
    "font-size": 70,
    "font-family": "Calibri",
    fill: "white"
});

//Draw the red rectangle
var rect = paper.rect(90, 1, 98, 70, 15);
rect.attr({
    fill: "#EC262A",
    stroke: 'none'
});

tube.toFront();
