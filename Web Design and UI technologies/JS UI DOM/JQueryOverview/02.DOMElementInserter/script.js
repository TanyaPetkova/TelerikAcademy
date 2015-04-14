function createElement(selector, element, position) {
    var $currentElement = $(selector);
    var $newElement = $("<"+element+">").addClass("new");
 
    if(position ==='before')
    {
        $newElement.insertBefore($currentElement);
    }
    else
    {
        $newElement.insertAfter($currentElement);
    }
}