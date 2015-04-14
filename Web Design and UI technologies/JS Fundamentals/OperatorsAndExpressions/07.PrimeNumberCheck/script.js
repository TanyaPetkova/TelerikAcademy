//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

var number,
    message = 'Enter a positive integer number';

number = validateInput(message);

if (primeNumberCheck(number)) {
    alert('The number ' + number + ' is prime.');
} else {
    alert('The number ' + number + ' is NOT prime.');
}

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value) && value > 0 && value <= 100;
}

function validateInput(message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function primeNumberCheck(number) {

    for (var i = 2; i <= Math.sqrt(number) ; i += 1) {
        if (number % i === 0) {
            return false;
        }
    }

    return true;
}