function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);

    var leftBox = document.createElement('div');
    var title = document.createElement('h1');

    title.innerHTML = 'Cats';
    title.style.textAlign = 'center';

    leftBox.appendChild(title);

    leftBox.setAttribute('id', 'left-box');
    leftBox.style.display = 'inline';
    leftBox.style.width = '400px';
    leftBox.style.height = '400px';
    leftBox.style.float = 'left';

    container.appendChild(leftBox);

    var img = document.createElement('img');
    img.setAttribute('id', 'bigger-image');
    img.style.display = 'inline';
    img.style.width = '350px';
    img.style.height = '270px';
    img.style.borderRadius = '10px';
    img.src = items[0].url;
    leftBox.appendChild(img);

    leftBox.appendChild(img);

    var rightBox = document.createElement('div');
    rightBox.setAttribute('id', 'right-box');
    rightBox.style.display = 'inline';
    rightBox.style.width = '150px';
    rightBox.style.height = '400px';
    rightBox.style.float = 'left';

    container.appendChild(rightBox);

    var caption = document.createElement('div');
    caption.innerHTML = 'Filter';
    caption.style.textAlign = 'center';
    var input = document.createElement('input');
    var list = document.createElement('ul');
    var li = document.createElement('li');
    
    li.style.listStyle = 'none';

    for (var i = 0; i < items.length; i += 1) {
        var currentLi = li.cloneNode(true);
        currentLi.innerHTML = items[i].title;
        var image = document.createElement('img');
        image.setAttribute('src', items[i].url);
        image.style.width = '150px';
        image.style.borderRadius = '10px';
        currentLi.appendChild(image);
        list.appendChild(currentLi);
    }
    
    rightBox.appendChild(caption);
    rightBox.appendChild(input);
    rightBox.appendChild(list);

    function onImageMouseover(ev) {
        console.log(this.parentElement);
         this.parentElement.background = 'lightgray';
    }

    var images = document.querySelectorAll('#right-box img');

    for (var i = 0; i < images.length; i++) {
        images[i].addEventListener('mouseover', onImageMouseover);
    }
}
