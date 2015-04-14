var divsCount = 5,
    centerX = window.innerWidth / 2,
    centerY = window.innerHeight / 2,
    radius = 200,
    interval = 100,
    angle = 0;

var divs = new Array();
for (var i = 0; i < divsCount; i++) {
    var div = createDiv();
    divs.push(div);
}

setInterval(function () {
    var offsetAngle = 2 * Math.PI / divs.length;

    for (var i = 0; i < divs.length; i++) {
        var left = centerX + Math.cos(angle % 360 + offsetAngle * i) * radius;
        var top = centerY + Math.sin(angle % 360 + offsetAngle * i) * radius;

        divs[i].style.left = left + 'px';
        divs[i].style.top = top + 'px';
    }

    angle += 0.1;

}, interval);


function getRandomIntValue(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function getRandomColor() {
    var red = getRandomIntValue(0, 256);
    var green = getRandomIntValue(0, 256);
    var blue = getRandomIntValue(0, 256);

    var rgbColor = 'rgb(' + red + ', ' + green + ',' + blue + ')';
    return rgbColor;
}

function createDiv() {
    var div = document.createElement('div');

    //Create random width and height between 20px and 100px
    div.style.width = getRandomIntValue(20, 100) + 'px';
    div.style.height = getRandomIntValue(20, 100) + 'px';

    //Create random background color
    div.style.backgroundColor = getRandomColor();

    //Create random border radius
    div.style.borderRadius = getRandomIntValue(0, 100) + 'px';

    //Create random border color
    div.style.borderColor = getRandomColor();

    //Create random border width between 1px and 20px
    div.style.borderWidth = getRandomIntValue(1, 20) + 'px';
    div.style.borderStyle = 'solid';

    div.style.position = 'absolute';

    document.body.appendChild(div);

    return div;
}