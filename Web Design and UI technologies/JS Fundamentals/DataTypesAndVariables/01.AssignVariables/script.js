// Assign all the possible JavaScript literals to different variables.

//Array literal
var subjects = ['HQC', 'JS Fundamentals'];
console.log('subjects = ' + subjects.join(', ')); //HQC, JS Fundamentals 

//Boolean literal
var pi = Math.PI;
console.log('pi = ' + pi); // 3.141592653589793

var isEqual = (pi === 3.14);
console.log('isEqual = ' + isEqual); //false

//Integer
var integerLiteral = 7;
console.log('integerLiteral = ' + integerLiteral); //5

//Floating-point literal
var floatingPointLiteral = 0.75;
console.log('floatingPointLiteral = ' + floatingPointLiteral); //0.75

//Object literal
var student = {
    fullName: 'Pesho Goshov',
    age: 21
};
console.log(student);

//String literal
var institution = 'Telerik Academy';
console.log('institution = ' + institution); //'Telerik Academy'
