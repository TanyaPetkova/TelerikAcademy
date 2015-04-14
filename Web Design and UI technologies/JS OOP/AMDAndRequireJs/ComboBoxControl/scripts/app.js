(function () {
    'use strict';
    require.config({
        paths: {
            "jquery": "libs/jquery-2.1.1",
            "handlebars": "libs/handlebars-v1.3.0",
        }
    });

    require(['jquery','controls'], function ($, controls) {
        var people = [
          { id: 1, name: "Doncho Minkov", age: 25, avatarUrl: "images/minkov.jpg" },
          { id: 2, name: "Georgi Georgiev", age: 22, avatarUrl: "images/joreto.jpg" },
          { id: 3, name: "Ivaylo Kenov", age: 25, avatarUrl: "images/kenov.jpg" },
          { id: 4, name: "Nikolay Kostov", age: 24, avatarUrl: "images/kostov.jpg" },
        ];

        var comboBox = controls.ComboBox(people);
        var template = $("#person-template").html();
        var comboBoxHtml = comboBox.render(template);
        $('.comboBox').append(comboBoxHtml);
    });
}());