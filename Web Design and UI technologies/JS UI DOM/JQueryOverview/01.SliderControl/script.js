createSliderControl('#wrapper');

function createSliderControl(selector) {
    var $container = $(selector);

    $container.css('width', '600px');
    $container.css('height', '400px');
    $container.css('border', '1px solid black');
    $container.css('margin', 'auto');
    $container.css('text-align','center');
    //$content = ["<h1>Hello</h1>", ""];

    for (var i = 0; i < 5; i += 1) {
        var $holder = $('<div>').addClass('slides-list');
        $holder.attr("id", i);
        $holder.appendTo($container);
    }

    $('.slides-list').hide();
    $("#1").html("<img src='images/1.jpg' />");
    $("#2").html("<img src='images/2.jpg' />");
    $("#3").html("<img src='images/3.jpg' />");
    $("#4").html("<img src='images/4.jpg' />");
    $("#5").html("<img src='images/2.jpg' />");
    $("#1").addClass('current').show();

    var $leftArrow = $('<img>');
    var $rightArrow = $('<img>');

    $leftArrow.attr('src', "images/arrow_left.png");
    $rightArrow.attr('src', "images/arrow_right.png");
    $leftArrow.appendTo($container);
    $leftArrow.css('width', '100px');
    $leftArrow.css('height', '100px');
    $rightArrow.css('width', '100px');
    $rightArrow.css('height', '100px');
    $rightArrow.appendTo($container);
    $rightArrow.attr('id', 'right');

    $leftArrow.css('width', '100px');
    $leftArrow.css('height', '100px');
    $leftArrow.attr('id', 'left');

    function onButtonClick(){
        var $currentId = $('.current').attr('id');
        $('.slides-list').hide();
        $('.current').removeClass('current'); 
        if ($(this).attr('id') == 'right') {
            var id = (parseInt($currentId) + 1) % 5;
            console.log(id);
            $('#' + id).addClass('current').show();
        }
        else {
            var id = (parseInt($currentId) - 1) % 5 || 4;
            console.log(id);
            $('#' + id).addClass('current').show();
        }
    }

    $leftArrow.on('click', onButtonClick);
    $rightArrow.on('click', onButtonClick);
    setInterval(onButtonClick, 2000);   
}


    