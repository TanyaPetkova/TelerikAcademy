function solve(params) {
    var params0 = params[0].split(' ');
    var rows = parseInt(params0[0]);
    var cols = parseInt(params0[1]);
    var row = 0, col = 0;
    var sum = 0;
    var counter;

    var countMatrix = new Array();

    var matrix = new Array();
    for (var i = 0; i < rows; i++) {
        matrix[i] = new Array();
        var tempar = params[i + 1].split(' ');
        for (var j = 0; j < cols; j++) {
            matrix[i][j] = tempar[j];
        }
    }

    var counter = 1;
    for (var i = 0; i < rows; i++) {
        counter = Math.pow(2, i);
        countMatrix[i] = new Array();
        for (var j = 0; j < cols; j++) {
            countMatrix[i][j] = counter;
            counter = counter + 1;
        }
    }

    while (true) {
        sum = sum + countMatrix[row][col];
        countMatrix[row][col] = 0;

        switch (matrix[row][col]) {
            case 'dr':
                row = row + 1;
                col = col + 1;
                break;
            case 'dl':
                row = row + 1;
                col = col - 1;
                break;
            case 'ur':
                row = row - 1;
                col = col + 1;
                break;
            case 'ul':
                row = row - 1;
                col = col - 1;
                break;
            default:
        }
        if (row > rows - 1 || row < 0 || col > cols - 1 || col < 0) {
            console.log('successed with ' + sum);
            return;
        }

        if (countMatrix[row][col] === 0) {
            console.log( 'failed at (' + row + ', ' + col + ')');
            return;
        }
    }
}

