/* Write a function that formats a string using placeholders:

   var str = stringFormat('Hello {0}!', 'Peter');
   //str = 'Hello Peter!';

   The function should work with up to 30 placeholders and all types

   var frmt = '{0}, {1}, {0} text {2}';
   var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
   //str = '1, Pesho, 1 text Gosho'
*/
var str = stringFormat('Hello {0}!', 'Peter');
alert(str);

function stringFormat(parameters) {
    var frmt = arguments[0];
    for (var i = 0; i < arguments.length; i++) {
        var placeHolder = '{' + i + '}';
        while (frmt.indexOf(placeHolder) !== -1) {
            frmt = frmt.replace(placeHolder, arguments[i + 1]);
        }
    }

    return frmt;
}

