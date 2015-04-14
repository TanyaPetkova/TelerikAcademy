function solve(params) {
    var n = parseInt(params[0]);
    var gN = 3;
    var given = [3, 4, 10];
    var mp = new Array();
    mp[0] = n + 1;
    var counter = 0;
    devNum(n, 1);
    function devNum(n, pos) {
        var k, p;
        for (p = gN; p > 0; p--) {
            k = given[p - 1];
            if (n > k) {
                mp[pos] = k;
                if (mp[pos] <= mp[pos - 1]) {
                    devNum(n - k, pos + 1);
                }
            } else if (n === k) {
                mp[pos] = k;
                if (mp[pos] <= mp[pos - 1]) {
                    counter++;
                }
            }
        }
    }

    return counter;
}

var params = ['40'];
console.log(solve(params));
