var movingShapes = (function () {
    var circualDivs = new Array(),
        rectDivs = new Array(),
        centerX = window.innerWidth / 2,
        centerY = window.innerHeight / 2,
        radius = 200,
        interval = 100,
        angle = 0,
        maxWidth = 400,
        minWidth = 50,
        maxHeigth = 500,
        minHeigth = 50,
        step = 5,
        self;

    function moveCircular() {
        var offsetAngle = 2 * Math.PI / circualDivs.length;

        for (var i = 0; i < circualDivs.length; i++) {
            var left = centerX + Math.cos(angle % 360 + offsetAngle * i) * radius;
            var top = centerY + Math.sin(angle % 360 + offsetAngle * i) * radius;

            circualDivs[i].style.left = left + 'px';
            circualDivs[i].style.top = top + 'px';
        }

        angle += 0.1;

        for (var i = 0; i < rectDivs.length; i++) {
            rectDivs[i].direction = rectDivs[i].direction % 4;

            switch (rectDivs[i].direction) {
                case 0:
                    rectDivs[i].style.left = parseInt(rectDivs[i].style.left) + step + 'px';
                    if (parseInt(rectDivs[i].style.left) > maxWidth) {
                        rectDivs[i].direction += 1;
                    }
                    break;
                case 1:
                    rectDivs[i].style.top = parseInt(rectDivs[i].style.top) + step + 'px';
                    if (parseInt(rectDivs[i].style.top) > maxHeigth) {
                        rectDivs[i].direction += 1;
                    }
                    break;
                case 2:
                    rectDivs[i].style.left = parseInt(rectDivs[i].style.left) - step + 'px';
                    if (parseInt(rectDivs[i].style.left) < minWidth) {
                        rectDivs[i].direction += 1;
                    }
                    break;
                case 3:
                    rectDivs[i].style.top = parseInt(rectDivs[i].style.top) - step + 'px';
                    if (parseInt(rectDivs[i].style.top) < minHeigth) {
                        rectDivs[i].direction += 1;
                    }
                    break;
            }
        }
    }

    setInterval(moveCircular, interval);

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

        //Create width and height 100px
        div.style.width = 100 + 'px';
        div.style.height = 100 + 'px';

        //Create random background color
        div.style.backgroundColor = getRandomColor();

        //Create random border color
        div.style.borderColor = getRandomColor();

        //Create border width 1px 
        div.style.borderWidth = 1 + 'px';
        div.style.borderStyle = 'solid';

        div.style.position = 'absolute';

        document.body.appendChild(div);

        return div;
    }

    function add(movementType) {
        switch (movementType) {
            case 'rect':
                var rectDiv = createDiv();
                rectDiv.style.top = 50 + 'px';
                rectDiv.style.left = 50 + 'px';
                rectDiv.direction = 0;
                rectDivs.push(rectDiv);
                setInterval();
                break;
            case 'ellipse':
                var circDiv = createDiv();
                circualDivs.push(circDiv);
                setInterval();
                break;
            default: alert('Invalid movement type!');
                break;
        }
    }

    self = {
        add: add
    }

    return self;
})();

var addRectButton = document.querySelector('.rect');
var addEllipseButton = document.querySelector('.ellipse');

addEllipseButton.addEventListener('click', function () { movingShapes.add("ellipse"); });
addRectButton.addEventListener('click', function () { movingShapes.add("rect"); });

