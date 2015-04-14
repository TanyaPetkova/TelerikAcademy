//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var text = '',
    inputMessage = 'Enter a text:',
    words,
    palindromes;

text = prompt(inputMessage);
palindromes = extractPalindromes(text);
alert(palindromes);

function extractPalindromes(text) {
    var i,
        words = text.split(' '),
        palindromes = new Array();

    for (i = 0; i < words.length; i += 1) {
        var isPalindrom = false;
        for (var j = 0; j < words[i].length; j += 1) {
            if (words[i][j] === words[i][words[i].length - 1 - j]) {
                isPalindrom = true;
            } else {
                isPalindrom = false;
                break;
            }
        }

        if (isPalindrom && words[i].length !== 1) {
            palindromes.push(words[i]);
        }
    }

    return palindromes;
}

