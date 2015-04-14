window.onload = function () {
    var forms = document.querySelectorAll("input[type = text");
    printTextFormValue(forms);

    function printTextFormValue(textForms) {
        for (var i = 0; i < textForms.length; i++) {
            console.log(textForms[i].value);
        }
    }
}