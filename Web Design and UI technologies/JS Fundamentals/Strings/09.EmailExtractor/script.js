/* Write a function for extracting all email addresses from given text. 
   All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails. 
   Return the emails as array of strings.
*/

var text,
    inputMessage = 'Enter a text:',
    emails;

text = prompt(inputMessage);
emails = extractEmails(text);
alert(emails);

function extractEmails(text) {
    var emails = new Array(),
        monekeyA = '@',
        whiteSpace = ' ',
        leftIndex,
        rightIndex,
        currentIndex = 0;

    while (text.indexOf(monekeyA, currentIndex) !== -1) {
        currentIndex = text.indexOf(monekeyA, currentIndex);
        leftIndex = text.lastIndexOf(whiteSpace, currentIndex);
        rightIndex = text.indexOf(whiteSpace, currentIndex);
        if (rightIndex !== -1) {
            emails.push(text.substring(leftIndex, rightIndex));
            currentIndex = rightIndex;
        } else {
            currentIndex = text.length;
            emails.push(text.substring(leftIndex, currentIndex));
        }     
    }

    return emails;
}

