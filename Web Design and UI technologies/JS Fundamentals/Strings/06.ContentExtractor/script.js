/* Write a function that extracts the content of a html page given as text. 
   The function should return anything that is in a tag, without the tags:

   <html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>

   result:

   Sample sitetextmore textand more...in body
*/

var htmlAsText,
    inputMessage = 'Enter HTML page content:',
    content;

htmlAsText = prompt(inputMessage);
content = extractContent(htmlAsText);
alert(content);

function extractContent(htmlAsText) {
    var openTag = '<',
        closeTag = '>',
        inTag = false,
        content = '';

    for (var i = 0; i < htmlAsText.length; i += 1) {
        if (htmlAsText[i] === openTag) {
            inTag = true;
        }
        else if (htmlAsText[i] === closeTag) {
            inTag = false;
            continue;
        }

        if (!inTag) {
            content += htmlAsText[i];
        }
    }

    return content;
}