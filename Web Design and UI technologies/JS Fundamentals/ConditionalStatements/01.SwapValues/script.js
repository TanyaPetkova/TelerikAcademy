//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

var firstNumber,
    secondNumber ,
    message = 'Enter an integer number:';

firstNumber = validateInput(firstNumber, message);
secondNumber = validateInput(secondNumber, message);
swapNumbers(firstNumber, secondNumber);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function swapNumbers(firstNumber, secondNumber) {
    if (firstNumber > secondNumber) {
        secondNumber += firstNumber;
        firstNumber = secondNumber - firstNumber;
        secondNumber -= firstNumber;
        alert('The values of the two numbers are exchanged: first number = ' + firstNumber + ' second number = ' + secondNumber);
    } else {
        alert('The values of the two numbers are NOT exchanged.');
    }
}
