//Write script that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

var digit,
    message = 'Enter a digit:';

digit = validateInput(digit, message);
showDigitName(digit);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value) && value < 10;
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function showDigitName(digit) {
    switch (parseInt(digit)) {
        case 0:
            alert('zero');
            break;
        case 1:
            alert('one');
            break;
        case 2:
            alert('two');
            break;
        case 3:
            alert('three');
            break;
        case 4:
            alert('four');
            break;
        case 5:
            alert('five');
            break;
        case 6:
            alert('six');
            break;
        case 7:
            alert('seven');
            break;
        case 8:
            alert('eight');
            break;
        case 9:
            alert('nine');
            break;
    }
}