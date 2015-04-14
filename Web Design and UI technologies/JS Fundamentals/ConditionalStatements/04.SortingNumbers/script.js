//Sort 3 real values in descending order using nested if statements.

var firstNumber,
    secondNumber,
    thirdNumber,
    message = 'Enter a number:';

firstNumber = validateInput(firstNumber, message);
secondNumber = validateInput(secondNumber, message);
thirdNumber = validateInput(thirdNumber, message);

sortDescending(firstNumber, secondNumber, thirdNumber);

function isNumber(value) {
    return !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isNumber(number))

    return number;
}

function sortDescending(firstNumber, secondNumber, thirdNumber) {
    if (firstNumber > secondNumber) {
        if (secondNumber > thirdNumber) {
            alert(firstNumber +  ' ' + secondNumber + ' ' + thirdNumber);
        }
        else {
            if (firstNumber > thirdNumber) {
                alert(firstNumber + ' ' + thirdNumber + ' ' + secondNumber);
            }
            else {
                alert(thirdNumber + ' ' + firstNumber + ' ' + secondNumber);
            }
        }
    }
    else {
        if (firstNumber > thirdNumber) {
            alert(secondNumber + ' ' + firstNumber + ' ' + thirdNumber);
        }
        else {
            if (thirdNumber > secondNumber) {
                alert(thirdNumber + ' ' + secondNumber + ' ' + firstNumber);
            }
            else {
                alert(secondNumber + ' ' + thirdNumber + ' ' + firstNumber);
            }
        }
    }
}