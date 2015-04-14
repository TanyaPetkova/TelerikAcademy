//Write a function to count the number of divs on the web page

var divCount;

divCount = countDivElements();

alert('The number of divs on the web page is ' + divCount);

function countDivElements(parameters) {
    divCount = document.getElementsByTagName('div').length;
    return divCount;
}
