/* Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
   Example: The target substring is "in". The text is as follows:

        We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
        So we are drinking all the day. We will move out of it in 5 days.

   The result is: 9.
*/

var text,
    textInputMessage = 'Enter a text:',
    keyword,
    keywordInputMessage = 'Enter a substring to be searched:',
    count;

text = prompt(textInputMessage);
text = text.toLowerCase();
keyword = prompt(keywordInputMessage);
keyword = keyword.toLowerCase();
count = countSubstring(text, keyword);

alert('The substring ' + keyword + ' is concatenated ' + count + ' many times in the given text.');

function countSubstring(text, keyword) {
    var index = text.indexOf(keyword),
        count = 0;

    while (index !== -1) {
        index = text.indexOf(keyword, index + 1);
        count++;
    }

    return count;
}