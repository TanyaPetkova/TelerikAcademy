//Write a script that compares two char arrays lexicographically (letter by letter).

var message = 'Enter a word to compare:';
    firstArray = prompt(message).toLowerCase(),
    secondArray = prompt(message).toLowerCase(),
    areEqual = true;

for (var i = 0; i < Math.min(firstArray.length, secondArray.length) ; i += 1) {
    if (firstArray[i] < secondArray[i]) {
        alert(firstArray + ' comes earlier lexicographically, than ' + secondArray);
        areEqual = false;
        break;
    }

    if (firstArray[i] > secondArray[i]) {
        alert(secondArray + ' comes earlier lexicographically, than ' + firstArray);
        areEqual = false;
        break;
    }
}

if (areEqual && firstArray.length === secondArray.length) {
    alert('The two arrays are equal.');
}
else if (areEqual && firstArray.length < secondArray.length) {
    alert(firstArray + ' comes earlier lexicographically, than ' + secondArray);
}
else if (areEqual && firstArray.length > secondArray.length) {
    alert(secondArray + ' comes earlier lexicographically, than ' + firstArray);
}

