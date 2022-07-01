/* 03. Implementar uma função que verifique se uma palavra aparece em um texto */

const prompt = require('prompt-sync')();

function contem(texto, palavra) {
    let c;

    for (let i = 0; i < texto.length; i++) {
        c = true;
        
        for (let j = 0; j < palavra.length; j++) {
            if (texto[i + j] != palavra[j]) {
                c = false;
                break;
            }
        }
        if (c) return true;
    }
    return false;
}

function main() {
    try {
        console.log('Verificar');
        let text = prompt('String: ');
        let word = prompt('Palavra: ');
        console.log(contem(text, word));
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
