/* Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
   Sample HTML fragment:

   <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
   Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

   <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
   Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
*/

var htmlAsString,
    inputMessage = 'Enter HTML document content:',
    replacedDocument;

htmlAsString = prompt(inputMessage);
replacedDocument = replaceAnchrorWithURL(htmlAsString);
alert(replacedDocument);

function replaceAnchrorWithURL(content) {
    var openAnchorTag = '<a href="',
        closeAnchorTag = '</a>',
        openUrlTag = '[URL=',
        closeUrlTag = '[/URL]',
        closeTag = '">',
        closeSquareBracket = ']',

        startIndex,
        endIndex,
        baseSubstring,
        targetSubstring;

    while (true) {
        startIndex = content.indexOf(openAnchorTag);
        if (startIndex === -1) {
            break;
        }
        endIndex = content.indexOf(closeTag, startIndex);
        baseSubstring = content.substr(startIndex, endIndex - startIndex + 2);

        targetSubstring = baseSubstring.replace(openAnchorTag, openUrlTag);
        targetSubstring = targetSubstring.replace(closeTag, closeSquareBracket);

        content = content.replace(baseSubstring, targetSubstring);
        content = content.replace(closeAnchorTag, closeUrlTag);
    }
    return content;
}