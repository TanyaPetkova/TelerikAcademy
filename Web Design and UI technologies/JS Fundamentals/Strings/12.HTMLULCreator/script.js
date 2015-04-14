﻿/* Write a function that creates a HTML UL using a template for every HTML LI. The source of the list should an array of elements. 
   Replace all placeholders marked with –{…}–   with the value of the corresponding property of the object. Example: 

   <div data-type="template" id="list-item">
   <strong>-{name}-</strong> <span>-{age}-</span>
   /div>

   var people = [{name: 'Peter', age: 14},…];
   var tmpl = document.getElementById('list-item').innerHtml;
   var peopleList = generateList(people, template);
   //peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'
*/

