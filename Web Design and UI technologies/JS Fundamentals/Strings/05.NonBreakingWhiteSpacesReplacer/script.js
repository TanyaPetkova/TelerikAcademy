//Write a function that replaces non breaking white-spaces in a text with &nbsp;

var text = '',
    inputMessage = 'Enter a text:',
    replacedText,
    nonBreakingWhiteSpace = '&nbsp';

String.prototype.replace = function (index, subString) {
    var replacedText = this.substr(0, index) + subString + this.substr(index + 1);
    return replacedText;
}

function replaceNonBreakingWhiteSpaces(text) {
    var i;
    for (i = 0; i < text.length - 1; i += 1) {
        if (text[i] === ' ') {
            while (text[i + 1] === ' ') {
                text = text.replace(i + 1, nonBreakingWhiteSpace);
                i += nonBreakingWhiteSpace.length;
            }
        }
    }

    return text;
}

text = prompt(inputMessage);
replacedText = replaceNonBreakingWhiteSpaces(text);
alert(replacedText);
