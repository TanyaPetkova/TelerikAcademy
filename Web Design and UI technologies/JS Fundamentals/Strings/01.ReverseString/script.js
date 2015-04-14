//Write a JavaScript function reverses string and returns itExample: "sample" -> "elpmas".

var text,
    inputMessage = 'Enter a text to be reversed',
    outputMessage = 'The reversed string is ',
    reversedString;

text = prompt(inputMessage);
reversedString = reverseString(text);
alert(outputMessage + reversedString);

function reverseString(string) {
    var i,
        reversedString = '';
    for (i = string.length - 1; i >= 0; i -= 1) {
        reversedString += string[i];
    }

    return reversedString;
}