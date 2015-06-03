var generator = {

    createParagraph : function createParagraph(id, text){
        document.getElementById(id).innerHTML += '<p>' + text + '</p>';
    },

    createDiv : function createDiv(id, className) {
        document.getElementById(id).innerHTML += '<div class =' + className + '></div>';
    },
    createLink : function createLink(id, text, url) {
        document.getElementById(id).innerHTML += '<a href=' + url + '>' + text + '</a>'
    }
};
generator.createParagraph('wrapper', 'Soft Uni');
generator.createDiv('wrapper', 'section');
generator.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');
