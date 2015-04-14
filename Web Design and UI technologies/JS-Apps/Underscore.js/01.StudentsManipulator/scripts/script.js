///<reference path="libs/underscore.js"/>
(function () {
    var Student = (function () {
        function Student(fname, lname, age) {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.marks = [];
        };

        Student.prototype = {
            fullName: function () {
                return this.fname + ' ' + this.lname;
            },

            addMark: function (mark) {
                this.marks.push(mark);
            }
        }
        return Student;
    }());

    var students = [
        new Student('Ivan', 'Hristov', 16),
        new Student('Hristo', 'Angelov', 21),
        new Student('Todor', 'Genchev', 22),
        new Student('Georgi', 'Hristozov', 18),
        new Student('Mihail', 'Nikolov', 25),
        new Student('Georgi', 'Kostov', 19),
        new Student('Todor', 'Stoychev', 18),
        new Student('Georgi', 'Hristov', 21)
    ];

    var marksCount = 10;

    for (var i = 0; i < students.length; i += 1) {
        for (var m = 0; m < marksCount; m += 1) {
            //random mark from 2 to 6
            var mark = Math.random() * 4 + 2;
            students[i].addMark(mark);
        }
    }

    var separator = '------------';

    console.log('Task 1');
    //Task 1
    (function getStudentsByFullName(students) {
        _.chain(students)
            .filter(function (student) {
                return student.fname < student.lname;
            })
                .sortBy(function (student) {
                    return student.fullName();
                })
                    .reverse()
                        .each(function (student) {
                            console.log(student.fullName());
                        });
    }(students));

    console.log(separator);
    console.log('Task2');
    //Task2
    (function getStudentsByAge(students) {
        _.chain(students)
            .filter(function (student) {
                return student.age >= 18 && student.age <= 24;
            })
                .each(function (student) {
                    console.log(student.fullName());
                });
    }(students));

    console.log(separator);
    console.log('Task3');
    //Task3
    (function getStudentsByHighestMarks(students) {
        _.chain(students)
            .each(function (student) {
                var sum = 0;
                for (var i = 0; i < student.marks.length; i += 1) {
                    sum += student.marks[i];
                }

                student.averageMark = sum / student.marks.length;
                console.log(student.averageMark);
            })
                .sortBy('averageMark')
                    .reverse()
                        .first()
                            .map(function (student) {
                                console.log(student);
                            });
    }(students));

    console.log(separator);
    console.log('Task7');
    //Task7
    (function getMostCommontName(students, name) {
        _.chain(students)
                   .countBy(name)
                        .pairs()
                            .sortBy(1)
                                .reverse()
                                        .first(1)
                                            .map(function (list) {
                                                console.log(list[0]);
                                            })
    }(students, 'fname'));
}());