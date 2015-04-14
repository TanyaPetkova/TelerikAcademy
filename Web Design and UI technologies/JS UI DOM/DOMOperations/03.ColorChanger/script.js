var firstInput = document.createElement('input'),
    secondInput = document.createElement('input'),
    textArea = document.createElement('textarea');

firstInput.setAttribute('type', 'color');
firstInput.style.display = 'block';

secondInput.setAttribute('type', 'color');
secondInput.style.display = 'block';

document.body.appendChild(firstInput);
document.body.appendChild(secondInput);
document.body.appendChild(textArea);

firstInput.onchange = function () {
    textArea.style.color = firstInput.value;
}

secondInput.onchange = function () {
    textArea.style.backgroundColor = secondInput.value;
}