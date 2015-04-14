var selectedElements = querySelector('div');
console.log(selectedElements);

selectedElements = querySelector('#wrapper');
console.log(selectedElements);

selectedElements = querySelector('div > div');
console.log(selectedElements);

function querySelector(selector) {
    var elements = Sizzle(selector);
    return elements;
}
