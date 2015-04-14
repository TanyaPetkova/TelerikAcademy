window.onload = function() {
    var selectedDivs = selectDivsByQuery();
    var selectedDivsCount = selectedDivs.length;
    document.getElementById("first-output-message").innerHTML = "First function: The number of all div nodes that are directly inside another div elements is " + selectedDivsCount;

    selectedDivs = selectDivsByTagName();
    selectedDivsCount = selectedDivs.length;
    document.getElementById("second-output-message").innerHTML = "Second function: The number of all div nodes that are directly inside another div elements is " + selectedDivsCount;

    function selectDivsByQuery() {
        var divs = document.querySelectorAll("div > div");
        return divs;
    }

    function selectDivsByTagName() {
        var allDivs = document.getElementsByTagName("div"),
            len = allDivs.length,
            divs = new Array();
        for (var i = 0; i < len; i++) {
            if (allDivs[i].parentNode.nodeName.toLowerCase() === "div") {
                divs.push(allDivs[i]);
            }
        }

        return divs;
    }
}