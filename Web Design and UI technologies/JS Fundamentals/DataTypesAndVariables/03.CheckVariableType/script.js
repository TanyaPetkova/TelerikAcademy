//Try typeof on all variables you created.

var subjects = ['HQC', 'JS Fundamentals'];
console.log('The type of the variable \'subjects\' is ' + typeof (subjects)); //object

var pi = Math.PI;
console.log('The type of the variable \'pi\' is ' + typeof (pi)); //number

var isEqual = (pi === 3.14);
console.log('The type of the variable \'isEqual\' is ' + typeof (isEqual)); //boolean

var integerLiteral = 7;
console.log('The type of the variable \'integerLiteral\' is ' + typeof (integerLiteral)); //number

var floatingPointLiteral = 0.75;
console.log('The type of the variable \'floatingPointLiteral\' is ' + typeof (floatingPointLiteral)); //number

var student = {
    fullName: 'Pesho Goshov',
    age: 21
};
console.log('The type of the variable \'student\' is ' + typeof (student)); //object

var institution = 'Telerik Academy';
console.log('The type of the variable \'institution\' is ' + typeof (institution)); //string

var quotedText = '\'How you doin\'?\', Joey said';
console.log('The type of the variable \'quotedText\' is ' + typeof (quotedText)); //string
