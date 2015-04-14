define(function () {
    'use strict';
    var Course;
    Course = (function () {
        function Course(title, formula) {
            this._title = title;
            this._students = [],
            this._formula = formula
        }

        Course.prototype = {
            addStudent: function (student) {
                this._students.push(student);
            },

            calculateResults: function () {
                var self = this;
                this._students.forEach(function (student) {
                    student.totalResult = self._formula(student);
                });
            },

            getTopStudentsByExam: function (count) {
                this._students.sort(function (first, second) {
                    return second.exam - first.exam;
                })

                var topStudents = this._students.slice(0, count);
                return topStudents;
            },

            getTopStudentsByTotalScore: function (count) {
                this._students.sort(function (first, second) {
                    return second.totalResult - first.totalResult;
                })

                var topStudents = this._students.slice(0, count);
                return topStudents;
            }
        };

        return Course;
    })();
    return Course;
});