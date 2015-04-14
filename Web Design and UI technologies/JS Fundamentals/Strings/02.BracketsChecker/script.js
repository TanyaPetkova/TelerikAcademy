/* Write a JavaScript function to check if in a given expression the brackets are put correctly.
   Example of correct expression: ((a+b)/5-d).
   Example of incorrect expression: )(a+b)).
*/

var expression,
    inputMessage = 'Enter an expression to be checked:',
    positiveOutputMessage = 'The brackets in the given expression are put correctly.',
    negativeOutputMessage = 'The brackets in the given expression are NOT put correctly.';

expression = prompt(inputMessage);
if (checkBrackets(expression)) {
    alert(positiveOutputMessage);
} else {
    alert(negativeOutputMessage);
}

function checkBrackets(expression) {
    var i,
        counter = 0,
        openBracket = '(',
        closeBracket = ')';
    for (i = 0; i < expression.length; i += 1) {
        if (expression[i] === openBracket) {
            counter++;
        }

        if (expression[i] === closeBracket) {
            counter--;
        }
    }

    if (counter === 0 && expression.indexOf(openBracket) < expression.indexOf(closeBracket) &&
        expression.lastIndexOf(openBracket) < expression.lastIndexOf(closeBracket)) {
        return true;
    } else {
        return false;
    }
}