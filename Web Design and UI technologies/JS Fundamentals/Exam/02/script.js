function solve(params) {
    var params0 = params[0].split(' ');
    var n = parseInt(params0[0]);
    var m = parseInt(params0[1]);

    var currentRow = 0;
    var currentCol = 0;

    var matrix = new Array();
    for (var i = 0; i < n; i++) {
        var counter = Math.pow(2, i);
        matrix[i] = new Array();
        for (var j = 0; j < m; j++) {
            matrix[i][j] = counter;
            counter++;
        }
    }

    var pattern = new Array();
    for (var k = 0; k < n; k++) {
        pattern[k] = new Array();
        var temp = params[1 + k].split(' ');
        for (var l = 0; l < m; l++) {
            pattern[k][l] = temp[l];
        }
    }

    var sumOfNumbers = matrix[currentRow][currentCol];
    while (true) {
        matrix[currentRow][currentCol] = 0;
        switch (pattern[currentRow][currentCol]) {
            case 'dr':
                currentCol += 1;
                currentRow += 1;
                break;
            case 'dl':
                currentCol -= 1;
                currentRow += 1;
                break;
            case 'ur':
                currentCol += 1;
                currentRow -= 1;
                break;
            case 'ul':
                currentCol -= 1;
                currentRow -= 1;
                break;
            default:
                break;
        }


        if (currentRow < 0 || currentRow > n - 1 || currentCol < 0 || currentCol > m - 1) {
            return 'successed with ' + sumOfNumbers;
        }

        if (matrix[currentRow][currentCol] === 0) {
            return 'failed at (' + currentRow + ', ' + currentCol + ')';
        }

        sumOfNumbers += matrix[currentRow][currentCol];
    }
}

var args = [
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
];



console.log(solve(args));