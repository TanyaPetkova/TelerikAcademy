$.fn.gallery = function (columns) {
    var $this = this,
        $galleryList = $this.find('.gallery-list'),
        $image = $this.find('img'),
        $selected = $('.selected'),
        $currentImage = $selected.find('.current-image img'),
        $nextImage = $selected.find('.next-image img'),
        $prevImage = $selected.find('.previous-image img'),
        $images = $this.find('.image-container'),
        rowsCount;

    $this.addClass('gallery');
    $this.find('.selected').hide();
    $selected.hide();

    if (!columns) {
        columns = 4;
    }

    rowsCount = parseInt($images.length / columns) + ($images.length % columns !== 0);

    generateGallery();

    function generateGallery() {
        for (var i = 0; i < rowsCount; i += 1) {
            var startIndex = i * columns;
            var endIndex = startIndex + columns - 1;
            generateRow(startIndex, endIndex);
        }
    }

    function generateRow(startIndex, endIndex) {
        var $currentRow = $('<div>').addClass('row');
        for (var i = startIndex; i <= endIndex && i < $images.length; i += 1) {
            $images.eq(i).appendTo($currentRow);
        }

        $currentRow.appendTo('.gallery-list');
    }

    $image.on('click', function () {
        var currentNumber,
            nextNumber,
            prevNumber;

        $galleryList.addClass('blurred');

        currentNumber = $(this).attr('data-info');
        nextNumber = (parseInt(currentNumber) + 1) % $images.length;
        prevNumber = (parseInt(currentNumber) - 1) % $images.length || 12;

        $currentImage.attr('src', 'imgs/' + currentNumber + '.jpg');
        $nextImage.attr('src', 'imgs/' + nextNumber + '.jpg');
        $prevImage.attr('src', 'imgs/' + prevNumber + '.jpg');
        $selected.show(); 
    })
};

