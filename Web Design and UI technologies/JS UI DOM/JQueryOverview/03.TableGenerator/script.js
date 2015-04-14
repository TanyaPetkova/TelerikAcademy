var students = [{
    firstName: 'Peter',
    lastName: 'Ivanov',
    grade: 3
}, {
    firstName: 'Milena',
    lastName: 'Grigorova',
    grade: 6
}, {
    firstName: 'Gergana',
    lastName: 'Borisova',
    grade: 12
}, {
    firstName: 'Boyko',
    lastName: 'Petrov',
    grade: 7
}
];

var $table = $('<table>').appendTo('#wrapper'),
    $thead = $('<thead>').appendTo($table),
    $tr = $('<tr>').appendTo($thead),
    $tbody = $('<tbody>').appendTo($table);

$tr.append($('<th>').text('First name'));
$tr.append($('<th>').text('Last name'));
$tr.append($('<th>').text('Grade'));
for (var i = 0; i < students.length; i++) {
    $tr = $('<tr>').appendTo($table);
    $td = $('<td>').text(students[i].firstName).appendTo($tr);
    $td = $('<td>').text(students[i].firstName).appendTo($tr);
    $td = $('<td>').text(students[i].grade).appendTo($tr);

}