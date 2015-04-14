
(function ($) {
    $.fn.dropdown = function () {
        var selectTag = $(this);
        var    $container = $('<div/>');
        var  $ul = $('<ul/>');
        var  $li = $('<li/>');
        var $options;
        var  $elements; 

        
        selectTag.hide();

        $container.addClass('dropdown-list-container');

        $ul.addClass('dropdown-list-options');

        $li.addClass('dropdown-list-option');

        $options = selectTag.find('option');

        
        for (var i = 0; i < $options.length; i++) {
            var text = $options[i].text;
            $li.attr('data-value', i);
            $li.text(text);
             $ul.append($li.clone(true));
        }

        $ul.appendTo($container);
        selectTag.after($container);

        $elements = $ul.find('.dropdown-list-option');

        $elements.hide().first().show(); 

        $container.on('click', 'li', function () {
            var $clicked = $(this);
            $clicked.parent().find('.selected').removeClass('selected');
            $clicked.addClass('selected');
            $elements.toggle();
            $clicked.show();
            var optionIndex = parseInt($clicked.attr('data-value'));
            $optionTags.removeAttr('selected');
            $($optionTags[optionIndex]).attr('selected', 'selected');
            
        })

    }
}($));