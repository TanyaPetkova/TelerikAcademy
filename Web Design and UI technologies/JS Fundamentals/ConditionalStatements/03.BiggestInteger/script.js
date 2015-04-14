//Write a script that finds the biggest of three integers using nested if statements.

var firstNumber,
    secondNumber,
    thirdNumber,
    message = 'Enter an integer number:';

firstNumber = validateInput(firstNumber, message);
secondNumber = validateInput(secondNumber, message);
thirdNumber = validateInput(thirdNumber, message);

findBiggestInt(firstNumber, secondNumber, thirdNumber);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function findBiggestInt(firstNumber, secondNumber, thirdNumber) {
    if (firstNumber > secondNumber) {
        if (firstNumber > thirdNumber) {
            alert('The biggest of the three numbers is ' + firstNumber);
        }
        else {
            alert('The biggest of the three numbers is ' + thirdNumber);
        }
    }
    else {
        if (secondNumber > thirdNumber) {
           alert('The biggest of the three numbers is ' + secondNumber);
        }
        else {
            alert('The biggest of the three numbers is ' + thirdNumber);
        }
    }
}