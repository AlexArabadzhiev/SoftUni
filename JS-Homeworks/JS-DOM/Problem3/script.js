function createParagraph(id, text){
    var newElement = document.createElement('p');
    newElement.innerHTML = text;
    document.getElementById(id).appendChild(newElement);

}
createParagraph('wrapper', 'Some Text')