function solve(params) {
    var answer = 1;
    for (var i = 1; i < params.length - 1; i += 1) {
        params[i] = parseInt(params[i]);
        if (params[i + 1] < params[i]) {
            answer++;
        }
    }

    return answer;
}
