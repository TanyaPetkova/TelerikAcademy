var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net",
            "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"]

var tagCloud = generateTagCloud(tags, 17, 42);

function countWords(words) {
    var wordsCount = {};
    for (var i in words) {
        var word = words[i].toLowerCase();
        if (wordsCount[word]) {
            wordsCount[word]++;
        }
        else {
            wordsCount[word] = 1;
        }
    }

    return wordsCount
}

function getSortedKeys(obj) {
    var keys = [];
    for (var key in obj) {
        keys.push(key);
    }

    keys.sort(function (a, b) {
        return obj[a] - obj[b]
    });

    return keys;
}

function generateTagCloud(tags, minFontSize, maxFontSize) {

    var occurences = countWords(tags);
    console.log(occurences);

    var sortedKeys = getSortedKeys(occurences);
    console.log(sortedKeys);

    var pointer = occurences[sortedKeys[0]];
    var groupsCount = 1;

    for (var i = 1; i < sortedKeys.length; i++) {
        if (pointer !== occurences[sortedKeys[i]]) {
            groupsCount++;
        }

        pointer = occurences[sortedKeys[i]];
    }

    var sizeDifference = maxFontSize - minFontSize;
    var step = sizeDifference / groupsCount;
    var currentSize = minFontSize;

    pointer = occurences[sortedKeys[0]];
    var spans = new Array();
    var span = document.createElement('span');
    span.innerHTML = sortedKeys[0];
    span.style.fontSize = currentSize + step + 'px';
    spans.push(span);

    for (var i = 1; i < sortedKeys.length; i++) {
        if (pointer !== occurences[sortedKeys[i]]) {
            currentSize += step;
        }

        span = document.createElement('span');
        span.innerHTML = sortedKeys[i];
        span.style.fontSize = currentSize + step + 'px';
        spans.push(span);

        pointer = occurences[sortedKeys[i]];
    }

    insertSpans('#wrapper', spans, sortedKeys);
}

function getRandomIntValue(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function insertSpans(selector, spans, sortedKeys) {
    var element = document.querySelector(selector);

    for (var i = 0; i < spans.length; i++) {
        spans[i].style.left = getRandomIntValue(0, parseInt(element.style.width)) + 'px';
        console.log(spans[i].offsetWidth);
        spans[i].style.top = getRandomIntValue(0, (parseInt(element.style.height) - parseInt(spans[i].style.fontSize))) + 'px';
        spans[i].style.position = 'absolute';

        element.appendChild(spans[i]);
    }
}

