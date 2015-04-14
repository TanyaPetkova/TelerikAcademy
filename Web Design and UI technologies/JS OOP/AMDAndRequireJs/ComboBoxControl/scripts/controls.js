define(['jquery', 'handlebars'], function ($) {
    'use strict';
    function createComboBox(html) {
        var $filter = $('<div>').append(html).find('div'),
            $comboBox = $('<div>').attr('data-state', 'collapsed').append($filter),
            $comboBoxItems = $comboBox.children('div');

        for (var i = 1; i < $comboBoxItems.length; i += 1) {
            $($comboBoxItems[i]).hide();
        }

        $comboBoxItems.on('click', function () {
            var $parent = $(this).parent();

            if ($parent.attr('data-state') === 'collapsed') {
                $parent.children('div').show();
                $parent.attr('data-state', 'open');
            } else {
                $parent.children('div').hide();
                $(this).show();
                $parent.attr('data-state', 'collapsed');
            }
        });

        return $comboBox;
    }

    var ComboBox;
    ComboBox = (function () {
        function ComboBox(data) {
            if (!(this instanceof ComboBox)) {
                return new ComboBox(data);
            }

            this._data = data;
        }

        ComboBox.prototype = {
            render: function (templateSource) {
                var template = Handlebars.compile(templateSource),
                    html = template({
                        people: this._data
                    }),
                    $comboBox = createComboBox(html);

                return $comboBox;
            }
        }

        return ComboBox;
    }());

    return {
        ComboBox: ComboBox
    };
});