//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

var arrayLength = 20,
    array = new Array(arrayLength),
    numberFive = 5;

for (var i = 0; i < arrayLength; i += 1) {
    array[i] = i * numberFive;
}

alert(array.join(', '));