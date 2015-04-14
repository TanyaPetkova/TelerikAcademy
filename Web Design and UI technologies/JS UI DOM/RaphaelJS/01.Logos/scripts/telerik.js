var paper = Raphael(10, 10, 500, 500);

//Draw the Telerik logo
var telerikLogo = paper.path('M23 39 39 23 79 63 56 85 33 63 73 23 89 39');
telerikLogo.attr({
    'stroke-width': 10,
    stroke: '#5CE600'
});

//Draw the ''Telerik' name
var telerikText = paper.text(230, 62, 'Telerik');
telerikText.attr({
    'font-size': 80,
    'font-weight': 'bold',
    'font-family': 'Arial'
});

//Draw the trade mark
var tradeMarkCircle = paper.circle(370, 58, 8);

var tradeMarkSign = paper.text(370, 58, 'R');
tradeMarkSign.attr({
    'font-size': 12,
    stroke: '#000'
});

//Draw the Telerik slogan
var slogan = paper.text(263, 112, 'Develop experiences');
slogan.attr({
    'font-size': 32,
    'font-family': 'Arial',
});