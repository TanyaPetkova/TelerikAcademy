//Create random number of 'div' elements
var maxDivs = 20;

var numberOfDvis = getRandomIntValue(0, maxDivs);
for (var i = 0; i < numberOfDvis; i++) {
    createDiv();
}

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
    var div = document.createElement('div'),
    strong;

    //Create random width and height between 20px and 100px
    div.style.width = getRandomIntValue(20, 100) + 'px';
    div.style.height = getRandomIntValue(20, 100) + 'px';

    //Create random background color
    div.style.backgroundColor = getRandomColor();

    //Create random font color
    div.style.color = getRandomColor();
    //Create random border radius
    div.style.borderRadius = getRandomIntValue(0, 100) + 'px';

    //Create random border color
    div.style.borderColor = getRandomColor();

    //Create random border width between 1px and 20px
    div.style.borderWidth = getRandomIntValue(1, 20) + 'px';
    div.style.borderStyle = 'solid';

    //Create random position on the screen (position:absolute)
    div.style.left = getRandomIntValue(0, window.innerWidth - (parseInt(div.style.width) + parseInt(div.style.borderWidth) * 2)) + 'px';
    div.style.top = getRandomIntValue(0, window.innerHeight - (parseInt(div.style.height) + parseInt(div.style.borderWidth) * 2)) + 'px';
    div.style.position = 'absolute';

    //Create a strong element with text "div" inside the div
    strong = document.createElement('strong');
    strong.innerHTML = 'div';
    div.appendChild(strong);

    //Center the div content
    div.style.display = 'flex';
    div.style.justifyContent = 'center';
    div.style.alignItems = 'center';

    document.body.appendChild(div);
}