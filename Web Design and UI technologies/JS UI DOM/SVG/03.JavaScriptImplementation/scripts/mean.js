var svgNS = 'http://www.w3.org/2000/svg';
var svg = document.createElementNS(svgNS, 'svg');

svg.setAttribute('width', '300');
svg.setAttribute('height', '400');

document.body.appendChild(svg);

//Draw the main rectangle
drawRect(10, 10, 5, 5, 250, 350, '#F5FFE0', '#DAEDF2');

//Draw the letters
drawText(40, 100, '#3E3F37', 2, '#3E3F37', '30px', 'arial', 'M');
drawText(40, 160, '#282827', 2, '#282827', '30px', 'arial', 'E');
drawText(40, 220, '#E23337', 2, '#E23337', '30px', 'arial', 'A');
drawText(40, 280, '#8EC74E', 2, '#8EC74E', '30px', 'arial', 'N');

//Draw the gray circle
drawCircle(150, 100, 60, '#3E3F37');

//Draw the leaf
drawPath('none', '#5EB14A', 'M 150 70 V 130 Q 120 100 150 70');
drawPath('none', '#449644', 'M 150 70 V 130 Q 180 100 150 70');

//Draw the black circle
drawCircle(150, 160, 60, '#282827');

//Draw the 'express' text
drawText(95, 160, 'none', 1, '#FFF', '25px', 'calibri', 'express', 5);

//Draw the red circle
drawCircle(150, 220, 60, '#E23337');

//Draw the letter 'A'
drawPath('none', '#B63032', 'M 150 185 L 190 200 L 185 245 L 150 245 Z');
drawPath('#B3B3B3', 'none', 'M 110 200 L 150 185 L 190 200 L 185 245 L 115 245 Z', 3);
drawPath('#F2F2F2', '#F2F2F2', 'M 150 230 H 142 L 137 240 H 131 L 150 187 V 202 L 144 225 H 150 Z');
drawPath('#B3B3B3', '#B3B3B3', 'M 150 230 H 157 L 162 240 H 168 L 150 187 V 202 L 155 225 H 150 Z');

//Draw the green circle
drawCircle(150, 280, 60, '#8EC74E');

var image = document.createElementNS(svgNS, 'image');

image.setAttribute('x', 100);
image.setAttribute('y', 245);
image.setAttribute('width', 100);
image.setAttribute('height', 50);

var xlinkNS = "http://www.w3.org/1999/xlink";

image.setAttributeNS(xlinkNS, "href", "node.png");

svg.appendChild(image);

function drawRect(x, y, rx, ry, width, height, fillColor, strokeColor) {
    var rect = document.createElementNS(svgNS, 'rect');

    rect.setAttribute('x', x);
    rect.setAttribute('y', y);
    rect.setAttribute('rx', rx);
    rect.setAttribute('ry', ry);
    rect.setAttribute('width', width);
    rect.setAttribute('height', height);
    rect.setAttribute('fill', fillColor);
    rect.setAttribute('stroke', strokeColor);

    svg.appendChild(rect);
}

function drawCircle(cx, cy, r, fill) {
    var circle = document.createElementNS(svgNS, 'circle');

    circle.setAttribute('cx', cx);
    circle.setAttribute('cy', cy);
    circle.setAttribute('r', r);
    circle.setAttribute('fill', fill);

    svg.appendChild(circle);
}

function drawText(x, y, strokeColor, strokeWidth, fillColor, fontSize, fontFamily, value, letterSpacing) {
    var text = document.createElementNS(svgNS, 'text');

    text.innerHTML = value;

    text.setAttribute('x', x);
    text.setAttribute('y', y);
    text.setAttribute('stroke', strokeColor);
    text.setAttribute('stroke-width', strokeWidth);
    text.setAttribute('fill', fillColor);
    text.setAttribute('font-size', fontSize);
    text.setAttribute('font-family', fontFamily);
    text.setAttribute('letter-spacing', letterSpacing);

    svg.appendChild(text);
}

function drawPath(strokeColor, fillColor, d, strokeWidth) {
    var path = document.createElementNS(svgNS, 'path');

    path.setAttribute('stroke', strokeColor);
    path.setAttribute('fill', fillColor);
    path.setAttribute('d', d);
    path.setAttribute('stroke-width', strokeWidth);

    svg.appendChild(path);
}
