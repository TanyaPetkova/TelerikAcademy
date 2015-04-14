var domModule = (function () {
    var maxCount = 4,
        buffer,
        self;
    buffer = [];

    function appendChild(element, selector) {
        var parent = document.querySelector(selector);
        parent.appendChild(element);
    }

    function removeChild(elementAsString, selector) {
        var parent = document.querySelector(elementAsString);
        var child = parent.querySelector(selector);
        parent.removeChild(child);
    }

    function addHandler(selector, eventType, eventHandler) {
        var element = document.querySelector(selector);
        element.addEventListener(eventType, eventHandler);
    }

    function appendToBuffer(selector, element) {
        var parentElement = document.querySelector(selector);
        if (!buffer[selector]) {
            buffer[selector] = document.createDocumentFragment();
        }

        buffer[selector].appendChild(element);
        if (buffer[selector].childNodes.length === maxCount) {
            parentElement.appendChild(buffer[selector]);
            buffer[selector] = null;
        }
    }

    function getElements(selector) {
        var elements = document.querySelectorAll(selector);
        return elements;
    }

    self = {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        getElements: getElements,
        appendToBuffer: appendToBuffer
    }

    return self;
})();

var div = document.createElement("div");

//appends div to #wrapper
domModule.appendChild(div, "#wrapper");

//removes li:first-child from ul
domModule.removeChild("ul", "li:first-child");

//add handler to each a element with class button
domModule.addHandler("a.button", 'click', function () { alert("Clicked") });

for (var i = 0; i < 10; i++) {
    domModule.appendToBuffer('#wrapper', div.cloneNode(true));
}

//get all list item elements inside the element with id 'wrapper'
var elements = domModule.getElements("#wrapper li");
console.log(elements);
