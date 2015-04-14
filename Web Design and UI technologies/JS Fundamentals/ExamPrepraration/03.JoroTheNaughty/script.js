function solve(params) {
    var params0 = params[0].split(' ');
    var n = parseInt(params0[0]);
    var m = parseInt(params0[1]);
    var jumpsCount = parseInt(params0[2]);
    var matrix = [[n]];
    var counter = 1;
    for (var i = 0; i < n; i++) {
        for (var k = 0; k < m; k++) {
            matrix[i][k] = counter;
            counter++;
        }
    }

    var currentRowCol = params[1].split(' ');
    var currentRow = parseInt(currentRowCol[0]);
    var currentCol = parseInt(currentRowCol[1]);
    var jumpsMatrix = new Array;
    for (var l = 0; l < jumpsCount; l++) {
        jumpsMatrix[l] = new Array();
        var currentJump = params[2 + l].split(' ');
        jumpsMatrix[l][0] = parseInt(currentJump[0]);
        jumpsMatrix[l][1] = parseInt(currentJump[1]);
    }

    var sumOfNumbers = matrix[currentRow][currentCol];
    var count = 0;
    while (true) {
        currentRow += jumpsMatrix[count % jumpsCount][0];
        currentCol += jumpsMatrix[count % jumpsCount][1];

        if (currentRow < 0 || currentRow > n - 1 || currentCol < 0 || currentCol > m - 1) {
            return 'escaped ' + sumOfNumbers;
        }

        if (matrix[currentRow][currentCol] === 0) {
            return 'cought ' + count;
        }
        sumOfNumbers += matrix[currentRow][currentCol];
        count++;
        matrix[currentRow][currentCol] = 0;
    }
}

