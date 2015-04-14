/*Write a function that finds all the occurrences of word in a text
   - The search can case sensitive or case insensitive
   - Use function overloading
*/

var text,
    word,
    caseSensitiveCount,
    caseInsensitiveCount,
    inputMessageText = 'Enter some text:',
    inputMessageWord = 'Enter a word to be counted:';

text = prompt(inputMessageText);
word = prompt(inputMessageWord);
caseInsensitiveCount = getWordsCount(text, word, false);
caseSensitiveCount = getWordsCount(text, word, true);

alert('The word ' + word + ' appears ' + caseInsensitiveCount + ' times in that text. (case insensitive)');
alert('The word ' + word + ' appears ' + caseSensitiveCount + ' times in that text. (case sensitive)');


function getWordsCount(text, word, isCaseSensitive) {
    function getWordsCountCaseInsensitive() {
        var count = 0;
        var words = text.split(' ');
        for (var i = 0; i < words.length; i += 1) {
            if (words[i].toLowerCase() === word.toLowerCase()) {
                count++;
            }
        }
        return count;
    }

    function getWordsCountCaseSensitive() {
        var count = 0;
        var words = text.split(' ');
        for (var i = 0; i < words.length; i += 1) {
            if (words[i] === word) {
                count++;
            }
        }
        return count;
    }

    switch (arguments.length) {
        case 2:
            return getWordsCountCaseInsensitive(word);
        case 3:
            return isCaseSensitive ? getWordsCountCaseSensitive(word) : getWordsCountCaseInsensitive(word);
        default:
            return - 1;
    }
}


