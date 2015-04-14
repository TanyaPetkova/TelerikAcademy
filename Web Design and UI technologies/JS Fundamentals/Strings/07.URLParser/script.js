/* Write a script that parses an URL address given in the format:

   [protocol]://[server]/[resource]

   and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.
   For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:

   {protocol: 'http', server: 'www.devbg.org', 
    resource: '/forum/index.php'}
*/

var address,
    inputMessage = 'Enter an URL address:',
    url = {};

address = prompt(inputMessage);
url = parseURL(address);

alert(url);

function parseURL(address) {
    var startIndex = 0,
        endIndex = 0,
        protocol = '',
        server = '',
        ressource = '',
        slash = '/',
        doubleSlash = '://';

    if (address.indexOf(doubleSlash) > 0) {
        endIndex = address.indexOf(doubleSlash);
        protocol = address.substr(startIndex, endIndex - startIndex);
        address = address.replace(doubleSlash, '');
        startIndex = endIndex;
    }

    if (address.indexOf(slash) > 0) {
        endIndex = address.indexOf(slash);
        server = address.substr(startIndex, endIndex - startIndex);
        startIndex = endIndex;
    } else {
        server = address.substr(startIndex);
        startIndex = address.length;
    }

    if (startIndex !== address.length - 1) {
        ressource = address.substr(startIndex);
    }

    var url = {
        protocol: protocol,
        server: server,
        ressource: ressource,
        toString: function () {
            return 'protocol: ' + this.protocol + '\n' +
                   'server: ' + this.server + '\n' +
                   'ressource: ' + this.ressource;
        }
    };

    return url;
}



