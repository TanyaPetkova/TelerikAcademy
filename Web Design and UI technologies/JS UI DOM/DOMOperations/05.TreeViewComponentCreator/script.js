createTreeView('#wrapper');

function createTreeView(selector) {
    var container = document.querySelector(selector);
    container.className += 'tree-view';

    var nestedList = document.querySelectorAll('.tree-view > ul ul');
    for (var i = 0; i < nestedList.length; i++) {
        nestedList[i].style.display = 'none';
    }

    var allItems = document.querySelectorAll('.tree-view li');

    for (var i = 0; i < allItems.length; i++) {
        allItems[i].addEventListener('click', onClick);
    }

    function onClick() {
        var len = this.childNodes.length;
      
        for (var i = 0; i < len; i++) {
            if (this.childNodes[i] instanceof HTMLElement) {
                console.log(this.childNodes[i]);
                if (this.childNodes[i].style.display === 'none') {
                    this.childNodes[i].style.display = '';
                }
                else {
                    this.childNodes[i].parentNode.childNodes[i].style.display = 'none';
                }
            }
        }
    }
}