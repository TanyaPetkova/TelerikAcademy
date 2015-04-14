/* You are given a text. Write a function that changes the text in all regions:
   - <upcase>text</upcase> to uppercase.
   - <lowcase>text</lowcase> to lowercase
   - <mixcase>text</mixcase> to mix casing(random)

   We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. 
   We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

   	The expected result:

   We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

   Regions can be nested
*/

var text,
    inputMessage = 'Enter a text:';

text = prompt(inputMessage);
text = performCases(text);
alert(text);

function convertToUpper(content) {
    content = content.toUpperCase();
    return content;
}

function convertToLower(content) {
    content = content.toLowerCase();
    return content;
}

function convertToMix(content) {
    var i,
        replacedContent = '';
    for (i = 0; i < content.length; i += 1) {
        if (Math.floor(Math.random() * 2) === 0) {
            replacedContent += convertToUpper(content[i]);
        } else {
            replacedContent += convertToLower(content[i]);
        }
    }
    return replacedContent;
}

function performCases(text) {
    var endTag = '</',
        upperCase = 'u',
        lowerCase = 'l',
        mixCase = 'm',
        openUpCaseTag = '<upcase>',
        openLowCaseTag = '<lowcase>',
        openMixCaseTag = '<mixcase>',
        endIndex,
        startIndex,
        value;
    while (text.indexOf(endTag) !== -1) {
        endIndex = text.indexOf(endTag);
        endIndex += endTag.length;
        switch (text[endIndex]) {
            case upperCase:
                startIndex = text.lastIndexOf(openUpCaseTag, endIndex);
                value = text.substring(startIndex + openUpCaseTag.length, endIndex - endTag.length);
                value = convertToUpper(value);
                text = text.replace(text.substring(startIndex, endIndex + openUpCaseTag.length-1), value);
                break;
            case lowerCase:
                startIndex = text.lastIndexOf(openLowCaseTag, endIndex);
                value = text.substring(startIndex + openLowCaseTag.length, endIndex - endTag.length);
                value = convertToLower(value);
                text = text.replace(text.substring(startIndex, endIndex + openLowCaseTag.length-1), value);
                break;
            case mixCase:
                startIndex = text.lastIndexOf(openMixCaseTag, endIndex);
                value = text.substring(startIndex + openMixCaseTag.length, endIndex - endTag.length);
                value = convertToMix(value);
                text = text.replace(text.substring(startIndex, endIndex + openMixCaseTag.length-1), value);
                break;
            default:
                break;
        }
    }

    return text;
}

