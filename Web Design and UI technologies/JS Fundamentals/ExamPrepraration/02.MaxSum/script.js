function solve(params) {
    var answer = parseInt(params[1]);
    for (var i = 1; i < params.length; i++) {
        var currentSum = 0;
        params[i] = parseInt(params[i]);
        for (var j = i; j < params.length; j++) {
            currentSum += parseInt(params[j]);
            if (currentSum > answer) {
                answer = currentSum;
            }
        }
    }

    return answer;
}
