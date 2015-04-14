window.onload = function () {
    setBodyBackground();

    function setBodyBackground() {
        var form = document.querySelector("input[type = color");
        var color = form.value;
        document.body.style.backgroundColor = color;
    }
}