// Implementar uma função que retorne a posição de um caractere em um texto.

const prompt = require('prompt-sync')();

function indexe(text, chara) {
    for (let i = 0; i < text.length; i++) {
        if (text[i] == chara) return i;
    }
    return -1;
}

function main() {
    try {
        console.log('Index');
        let text = prompt('String: ');
        let word = prompt('Char: ');
        console.log(indexe(text, word));
    } catch (err) {
        console.log($`\nAn error has ocurred: {err.message}\n`);
        main();
    } finally {
        let repet = prompt('Again? [Y/n]');
        if (repet == 'n') {
            console.log('Goodbay');
        }
        else if (repet == '' || repet == 'y') {
            main();
        }
    }
}

main();
