var svgNS = 'http://www.w3.org/2000/svg';
var xlinkNS = "http://www.w3.org/1999/xlink";

var svg = document.createElementNS(svgNS, 'svg');

svg.setAttribute('width', '800');
svg.setAttribute('height', '600');

document.body.appendChild(svg);

//Draw the main rectangle
drawRect(0, 0, 550, 345, '#001941', '#DAEDF2', 3, 5, 5);

drawText(53, 45, '#DAEDF2', '25px', 'calibri', 'Start');
drawText(450, 33, '#DAEDF2', '15px', 'calibri', 'Richard');
drawText(473, 43, '#DAEDF2', '10px', 'calibri', 'Perry');

//Draw the 'Store' element
drawRect(53, 80, 53, 53, '#2877ED', '#001941', 3);
drawText(60, 128, '#FFF', '6px', 'calibri', 'Store');
drawImage(65, 90, 25, 25, 'images/store.png');

//Draw the 'Maps' element
drawRect(53, 133, 53, 53, '#5D3AB8', '#001941', 3);
drawText(60, 181, '#FFF', '6px', 'calibri', 'Maps');
drawImage(62, 140, 35, 35, 'images/maps.png');

//Draw the 'Xbox LIVE Games' element
drawRect(106, 80, 53, 53, '#5CA719', '#001941', 3);
drawText(110, 128, '#FFF', '6px', 'calibri');
drawImage(115, 87, 35, 35, 'images/XboxLiveGames.png');

//Draw the 'Internet Explorer' element
drawRect(106, 133, 53, 53, '#2F87EA', '#001941', 3);
drawText(110, 181, '#FFF', '6px', 'calibri', 'Internet Explorer');
drawImage(115, 140, 35, 35, 'images/IE.png');

//Draw the 'Video' element
drawRect(53, 186, 106, 53, '#D34827', '#001941', 3);
drawText(60, 234, '#FFF', '6px', 'calibri', 'Video');
drawImage(90, 196, 30, 30, 'images/video.png');

//Draw the 'Desktop' element
drawRect(53, 239, 106, 53, '#0F747C', '#001941', 3);
drawText(60, 287, '#FFF', '6px', 'calibri', 'Desktop');

//Draw the 'Photos' element
drawRect(159, 80, 106, 53, '#AF1B3F', '#001941', 3);
drawText(166, 128, '#FFF', '6px', 'calibri', 'Photos');
drawImage(200, 93, 25, 25, 'images/photos.png');

//Draw the 'Messaging' element
drawRect(159, 133, 106, 53, '#5434AF', '#001941', 3);
drawText(166, 181, '#FFF', '6px', 'calibri', 'Messaging');
drawImage(200, 146, 25, 25, 'images/messaging.png');

//Draw the 'Devon Hypnotize' element
drawRect(159, 186, 106, 53, '#009A18', '#001941', 3);
drawText(166, 202, '#FFF', '12px', 'calibri', 'Devon Hypnotize');
drawText(166, 210, '#FFF', '6px', 'calibri', 'something they can do about him');
drawText(166, 216, '#FFF', '6px', 'calibri', 'piles of book and scrollsnext to');
drawText(255, 235, '#FFF', '6px', 'calibri', '3');
drawImage(160, 218, 25, 25, 'images/mail.png');

//Draw the 'Weather' element
drawRect(159, 239, 106, 53, '#2D86EE', '#001941', 3);
drawText(166, 287, '#FFF', '6px', 'calibri', 'Weather');
drawImage(200, 250, 25, 25, 'images/weather.png');

//Draw the 'Calendar' element
drawRect(265, 80, 106, 53, '#029418', '#001941', 3);
drawText(272, 128, '#FFF', '6px', 'calibri', 'Calendar');
drawText(335, 105, '#FFF', '27px', 'calibri', '12');
drawText(335, 113, '#FFF', '6px', 'calibri', 'Monday');

//Draw the 'People' element
drawRect(265, 133, 106, 53, '#D9512B', '#001941', 3);
drawImage(273, 140, 25, 25, 'images/MikeGibbs.jpg');
drawImage(273, 167, 15, 15, 'images/people.png');
drawText(301, 147, '#FFF', '6px', 'calibri', 'Mike Gibbs, Troll Scount');
drawText(301, 154, '#FFF', '6px', 'calibri', 'and 5 others commented');
drawText(301, 161, '#FFF', '6px', 'calibri', 'on your photo');

//Draw the 'Pinball FX2' element
drawRect(265, 186, 53, 53, '#000', '#001941', 3);
drawText(272, 234, '#FFF', '6px', 'calibri', 'Pinball FX2');

//Draw the 'Solitaire' element
drawRect(318, 186, 53, 53, '#2D86EE', '#001941', 3);
drawText(325, 234, '#FFF', '6px', 'calibri', 'Solitaire');

//Draw the 'Camera' element
drawRect(265, 239, 53, 53, '#B51B41', '#001941', 3);
drawText(272, 287, '#FFF', '6px', 'calibri', 'Camera');
drawImage(277, 248, 30, 30, 'images/camera.png');

//Draw the 'Xbox Companion' element
drawRect(318, 239, 53, 53, '#5EA919', '#001941', 3);
drawText(322, 287, '#FFF', '6px', 'calibri', 'Xbox Companion');
drawImage(330, 248, 25, 25, 'images/XboxCompanion.png');

//Draw the 'Music' element
drawRect(394, 80, 106, 53, '#5434AF', '#001941', 3);
drawText(401, 128, '#FFF', '6px', 'calibri', 'Music');
drawImage(420, 85, 45, 45, 'images/music.png');

//Draw the 'Finance' element
drawRect(394, 133, 106, 53, '#009017', '#001941', 3);
drawText(401, 181, '#FFF', '6px', 'calibri', 'Finance');
drawImage(433, 148, 22, 22, 'images/finance.png');

//Draw the 'Reader' element
drawRect(394, 186, 53, 53, '#D44A26', '#001941', 3);
drawText(401, 234, '#FFF', '6px', 'calibri', 'Reader');
drawImage(410, 200, 22, 22, 'images/reader.png');

//Draw the 'Windows Explorer' element
drawRect(447, 186, 53, 53, '#012A6B', '#001941', 3);
drawText(457, 198, '#DAEDF2', '6px', 'calibri', 'Windows');
drawText(457, 205, '#DAEDF2', '6px', 'calibri', 'Explorer');
drawImage(457, 220, 15, 15, 'images/WindowsExplorer.png');

//Draw the 'Word Press' element
drawImage(395.5, 240, 104.5, 51.5, 'images/WordPress.jpg');

//Draw the '2S' element
drawRect(501.5, 81.5, 47, 50, '#FFF');
drawImage(501.5, 81.5, 50, 50, 'images/2S.jpg');

//Draw the 'unrecognized' element
drawRect(501.5, 134.5, 47, 50, '#0164A8');

//Draw the 'Sky Drive' element
drawRect(501.5, 187.5, 47, 50, '#2877ED');
drawText(508.5, 234, '#FFF', '6px', 'calibri', 'Sky Drive');
drawImage(517, 195, 35, 35, 'images/SkyDrive.png');

function drawRect(x, y, width, height, fillColor, strokeColor, strokeWidth, rx, ry) {
    var rect = document.createElementNS(svgNS, 'rect');

    rect.setAttribute('x', x);
    rect.setAttribute('y', y);
    rect.setAttribute('width', width);
    rect.setAttribute('height', height);
    rect.setAttribute('fill', fillColor);
    rect.setAttribute('stroke', strokeColor);
    rect.setAttribute('stroke-width', strokeWidth);
    rect.setAttribute('rx', rx);
    rect.setAttribute('ry', ry);

    svg.appendChild(rect);
}

function drawText(x, y, fillColor, fontSize, fontFamily, value) {
    var text = document.createElementNS(svgNS, 'text');

    text.innerHTML = value;

    text.setAttribute('x', x);
    text.setAttribute('y', y);
    text.setAttribute('fill', fillColor);
    text.setAttribute('font-size', fontSize);
    text.setAttribute('font-family', fontFamily);

    svg.appendChild(text);
}

function drawImage(x, y, width, height, source) {
    var image = document.createElementNS(svgNS, 'image');

    image.setAttribute('x', x);
    image.setAttribute('y', y);
    image.setAttribute('width', width);
    image.setAttribute('height', height);
    image.setAttributeNS(xlinkNS, "href", source);

    svg.appendChild(image);
}