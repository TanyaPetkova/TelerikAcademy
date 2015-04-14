//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects

var documentElements,
    smallestProperty,
    largestProperty;

findMinMaxProperty(document);
findMinMaxProperty(window);
findMinMaxProperty(navigator);

function findMinMaxProperty(object) {
    smallestProperty = 'z',
    largestProperty = 'A';
    for (var property in object) {
        if (property < smallestProperty) {
            smallestProperty = property;
        }

        if (property > largestProperty) {
            largestProperty = property;
        }
    }

    alert('The lexicographically smallest property in ' + object + ' is ' + smallestProperty);
    alert('The lexicographically largest property in ' + object + ' is ' + largestProperty);
}



