/*Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0 -> 'Zero'
	273 -> 'Two hundred seventy three'
	400 -> 'Four hundred'
	501 -> 'Five hundred and one'
	711 -> 'Seven hundred and eleven'
*/

var number,
    message = 'Enter a number in the range [0...999]:',
    output = '';

number = validateInput(number, message);
convertNumberToText(number);

function isInt(value) {
    return parseFloat(value) === parseInt(value) && !isNaN(value) && value < 1000;
}

function validateInput(number, message) {
    do {
        number = prompt(message);
    } while (!isInt(number))

    return number;
}

function getWord(number) {
    switch (number) {
        case 0:
            output += 'zero ';
            break;
        case 1:
            output += 'one ';
            break;
        case 2:
            output +='two ';
            break;
        case 3:
            output +='three ';
            break;
        case 4:
            output +='four ';
            break;
        case 5:
            output +='five ';
            break;
        case 6:
            output +='six ';
            break;
        case 7:
            output +='seven ';
            break;
        case 8:
            output +='eight ';
            break;
        case 9:
            output +='nine ';
            break;
        case 10:
            output +='ten ';
            break;
        case 11:
            output +='eleven ';
            break;
        case 12:
            output +='twelve';
            break;
        case 13:
            output +='thirteen';
            break;
        case 14:
            output +='fourteen';
            break;
        case 15:
            output +='fifteen';
            break;
        case 16:
            output +='sixteen';
            break;
        case 17:
            output +='seventeen';
            break;
        case 18:
            output +='eighteen';
            break;
        case 19:
            output +='ninteen';
            break;
        case 20:
            output +='twenty ';
            break;
        case 30:
            output +='thirty ';
            break;
        case 40:
            output +='fourty ';
            break;
        case 50:
            output +='fifty ';
            break;
        case 60:
            output +='sixty ';
            break;
        case 70:
            output +='seventy ';
            break;
        case 80:
            output +='eighty ';
            break;
        case 90:
            output +='ninety ';
            break;
    }
}

function convertNumberToText(number) {
    if (number <= 20) {
        getWord(number);
    }
    else if (number >= 20 && number <= 99) {
        getWord(number - (number % 10));

        if (number % 10 !== 0) {
            getWord(number % 10);
        }
    }
    else {
        getWord(parseInt(number / 100));
        output +="hundred ";
        if (number % 100 !== 0) {
            if (number % 100 <= 20 || ((number % 100) % 10) === 0) {
                output +="and ";
                getWord(number % 100);
            }
            else {
                getWord((number % 100) - ((number % 100) % 10));

                if ((number % 100) % 10 !== 0) {
                    getWord((number % 100) % 10);
                }
            }
        }
    }

    alert(output);
}