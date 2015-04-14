/*Write a script that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
*/

var a,
    b,
    c,
    discriminant,
    x1,
    x2;

a = validateInput(a, 'Enter the coefficient a of a quadratic equation:');
b = validateInput(b, 'Enter the coefficient b of a quadratic equation:');
c = validateInput(c, 'Enter the coefficient c of a quadratic equation:');

discriminant = b * b - 4 * a * c;
calcQuadraticEquationRoots(a, b, c);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value);
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function calcQuadraticEquationRoots(a, b, c) {
    if (discriminant === 0) {
        x1 = x2 = -b / (2 * a);
        alert('The quadratic equation has one real root x1 = x2 = ' + x1);
    }
    else if (discriminant > 0) {
        x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.sqrt(discriminant)) / (2 * a);
        alert('The quadratic equation has two real roots x1 = ' + x1 + ' and x2 = ' + x2);
    }
    else {
        alert('The quadratic equation has no real roots.');
    }
}

