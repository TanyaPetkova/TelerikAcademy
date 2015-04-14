//Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

var firstNumber,
    secondNumber,
    thirdNumber,
    message = 'Enter a number:';

firstNumber = validateInput(firstNumber, message);
secondNumber = validateInput(secondNumber, message);
thirdNumber = validateInput(thirdNumber, message);

productOfRealNumbers(firstNumber, secondNumber, thirdNumber);

function isNumber(value) {
    return !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isNumber(number))

    return number;
}

function productOfRealNumbers(firstNumber, secondNumber, thirdNumber) {
    if (firstNumber === 0 || secondNumber === 0 || thirdNumber === 0) {
        alert('The product of ' + firstNumber + ' * ' + secondNumber + ' * ' + thirdNumber + ' = 0');
    }
    else if ((firstNumber > 0 && ((secondNumber > 0 && thirdNumber > 0) || (secondNumber < 0 && thirdNumber < 0)))
        || (firstNumber < 0 && ((secondNumber > 0 && thirdNumber < 0) || (secondNumber < 0 && thirdNumber > 0)))) {
        alert('The sign of ' + firstNumber + ' * ' + secondNumber + ' * ' + thirdNumber + ' is +.');
    }
    else {
        alert('The sign of ' + firstNumber + ' * ' + secondNumber + ' * ' + thirdNumber + ' is -.');
    }
    
}