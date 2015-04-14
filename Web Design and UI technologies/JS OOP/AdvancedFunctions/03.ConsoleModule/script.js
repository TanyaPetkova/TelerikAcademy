var specialConsole = (function () {
    var self;

    function formatString(args) {
        var string = args[0];
        for (var i = 1; i < args.length; i++) {
            while (string !== string.replace('{' + (i - 1) + '}', args[i])) {
                string = string.replace('{' + (i - 1) + '}', args[i]);
            }
        }

        return string;
    }

    function writeLine() {
        var message = formatString(arguments);
        console.log(message);
    }

    function writeError() {
        var error = formatString(arguments);
        console.error(error);
    }

    function writeWarning() {
        var warn = formatString(arguments);
        console.warn(warn);
    }

    self = {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    }

    return self;
})();

specialConsole.writeLine("Message: hello");

//logs to the console "Message: hello"
specialConsole.writeLine("Message: {0}", "hello");

//logs to the console error and warning messages
specialConsole.writeError("Error: {0}", "Something happened");
specialConsole.writeWarning("Warning: {0}", "A warning");
